using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCrashed : MonoBehaviour {

	private Letters letter;
	public GameObject crashed;

	void Start(){
		letter = GetComponent<Letters>();
	}

	void Update(){
		if(letter.index == letter.sentences.Length){
			crashed.SetActive(true);
		}
	}

}
