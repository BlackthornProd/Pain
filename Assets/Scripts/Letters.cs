using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letters : MonoBehaviour {

	public string sentence;
	public string[] sentences;
	public int index;

	public Text dialog;
	private Player player;
	public Bubble bubble;
	public bool dialogTwo;

	public bool heroSpeech;

	void Start(){
		StartCoroutine(Type());
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}


	void Update(){


		if(index >= sentences.Length){// character can now move
			player.canMove = true;
			this.gameObject.SetActive(false);

			Debug.Log("jojojo");
		
		} else {
			Debug.Log("HEOO");
			player.canMove = false;

		}

		if(Input.GetKeyDown(KeyCode.Space) && index < sentences.Length-1 && dialog.text == sentence){ // say dialog
			if(dialogTwo == true){
				bubble.Move();
			}

			dialog.text = "";
			index++;
			sentence = sentences[index];
			StartCoroutine(Type());
		} 



		if(Input.GetKeyDown(KeyCode.Space) && index == sentences.Length -1 && dialog.text == sentence){
			heroSpeech = true;
			index++;
			dialog.text = "";
			if(dialogTwo == true){
				bubble.End();
			}

		}
	}

	IEnumerator Type(){

		foreach(char letter in sentence.ToCharArray()){
			dialog.text += letter;
			yield return new WaitForSeconds(0.02f);
		}
	}
}
