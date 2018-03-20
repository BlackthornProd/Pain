using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTextManager : MonoBehaviour {

	public GameObject textManager;

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			textManager.SetActive(true);
		}
	}
}
