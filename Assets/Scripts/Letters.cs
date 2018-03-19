using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letters : MonoBehaviour {

	public string sentence;
	public string[] sentences;
	private int index;

	public Text dialog;
	private Player player;

	void Start(){
		StartCoroutine(Type());
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}


	void Update(){

		if(index >= sentences.Length ){
			player.canMove = true;
		} else {
			player.canMove = false;
		}


		if(Input.GetKeyDown(KeyCode.Space) && index < sentences.Length-1 && dialog.text == sentence){
			dialog.text = "";
			index++;
			sentence = sentences[index];
			StartCoroutine(Type());
		} 

		if(Input.GetKeyDown(KeyCode.Space) && index == sentences.Length -1 && dialog.text == sentence){
			index++;
			dialog.text = "";
		}
	}

	IEnumerator Type(){

		foreach(char letter in sentence.ToCharArray()){
			dialog.text += letter;
			yield return new WaitForSeconds(0.02f);
		}
	}
}
