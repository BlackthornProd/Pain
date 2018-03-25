using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {

	public float speed;

	public Transform[] positions;
	bool movingRight = true;

	public int hp;

	private ScreenShake shake;
	public Animator anim;
	private Animator heroAnim;
	public bool canMove = false;

	private PlayerDeath death;

	void Start(){
		death = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
		shake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ScreenShake>();
		heroAnim = GetComponent<Animator>();

	}

	void Update(){

		if(canMove == true){
			heroAnim.SetBool("isRunning", true);
			if(movingRight == true){
				transform.position = Vector2.MoveTowards(transform.position, positions[0].position, speed * Time.deltaTime);
			} else {
				transform.position = Vector2.MoveTowards(transform.position, positions[1].position, speed * Time.deltaTime);
			}

			if(transform.position == positions[0].position && movingRight == true){
				movingRight = false;
			} else if(transform.position == positions[1].position && movingRight == false){
				movingRight = true;
			}


			if(hp <= 0){
				death.Death();
			}
		} else {
			heroAnim.SetBool("isRunning", false);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			anim.SetTrigger("Flash");
			hp--;
			shake.Shake(0.75f, 0.55f);
		}
	}
}
