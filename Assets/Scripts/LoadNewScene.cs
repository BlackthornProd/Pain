using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {

	public string sceneName;


	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			SceneManager.LoadScene(sceneName);
		}
	}
}
