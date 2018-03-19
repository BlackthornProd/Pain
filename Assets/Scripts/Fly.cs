using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {

	private float speed;
	public float max;
	public float min;
	private Transform player;
	private float distance;
	public float m;
	public float mi;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		speed = Random.Range(min, max);
		distance = Random.Range(m, mi);
	}

	void Update(){

		if(Vector2.Distance(transform.position, player.position) < distance){
			transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
		}
	}

}
