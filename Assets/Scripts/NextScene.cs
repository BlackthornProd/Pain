using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	public Animator anim;

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("Player")){
			StartCoroutine(FadeIn());
		}

	}

	IEnumerator FadeIn(){
		anim.SetTrigger("FadeIn");
		yield return new WaitForSeconds(1.75f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
