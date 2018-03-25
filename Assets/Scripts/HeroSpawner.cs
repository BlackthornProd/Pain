using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSpawner : MonoBehaviour {

	public GameObject hero;

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			hero.SetActive(true);
		}
	}
}
