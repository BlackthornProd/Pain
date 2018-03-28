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

	if(other.CompareTag("Player") || other.CompareTag("Hero")){
			shake.Shake(.55f, 0.25f);
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}

