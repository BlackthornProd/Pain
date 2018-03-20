using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	private Transform player;
	private float speed;
	public float minSpeed;
	public float maxSpeed;
	private float distance;
	public float minDistance;
	public float maxDistance;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		speed = Random.Range(minSpeed, maxSpeed);
		distance = Random.Range(minDistance, maxDistance);
	}

	void Update(){

		if(Vector2.Distance(transform.position, player.position) < distance){
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
		} 

	}
}
