using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

	private SpriteRenderer rend;
	public Sprite[] tufts;
	private Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
		rend = GetComponent<SpriteRenderer>();
		int rand = Random.Range(0, tufts.Length);
		rend.sprite = tufts[rand];
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			anim.SetTrigger("Move");
		}
	}
}
