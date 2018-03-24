using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour {

	private Letters letter;
	public bool disabled;
	public SpriteRenderer[] rend;

	void Start(){
		letter = GameObject.FindGameObjectWithTag("GM").GetComponent<Letters>();
	}


	public void Move(){
		if(disabled == true){
				disabled = false;
				rend[0].enabled = true;
				rend[1].enabled = false;
			} else if(disabled == false){
				disabled = true;
				rend[0].enabled = false;
				rend[1].enabled = true;
			}
	}

	public void End(){
		rend[0].enabled = false;
			rend[1].enabled = false;
	}
}
