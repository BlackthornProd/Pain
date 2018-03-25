using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWait : MonoBehaviour {

	public Letters letter;
	public Hero hero;

	void Update(){

		if(letter.heroSpeech == true){
			hero.canMove = true;
			Debug.Log("HEROOOOOOOO");
		}
	}
}
