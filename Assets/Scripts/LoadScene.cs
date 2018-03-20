using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {



	public float time;

	void Update(){
		if(time <= 0){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		} else {
			time -= Time.deltaTime;
		}
	}

}
