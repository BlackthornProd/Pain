using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour {

	public GameObject deathEffect;

	void OnTriggerEnter2D(Collider2D other){

	if(other.CompareTag("Player")){
			deathEffect.SetActive(true);
		}
	}
}
