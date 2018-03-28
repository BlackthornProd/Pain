using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameManager : MonoBehaviour {

	public GameObject animationTwo;
	public float waitTime;
	public GameObject textManager;

	void Update(){

		if(waitTime <= 0){
			animationTwo.SetActive(true);
			textManager.SetActive(true);
		} else {
			waitTime -= Time.deltaTime;
		}
	}
}
