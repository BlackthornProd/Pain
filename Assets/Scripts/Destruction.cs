using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject deathEffect;
	private ScreenShake shake;

	void Start(){
		shake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<ScreenShake>();;
	}

	void OnTriggerEnter2D(Collider2D other){

	if(other.CompareTag("Player")){
			shake.Shake(0.25f, 0.25f);
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}

