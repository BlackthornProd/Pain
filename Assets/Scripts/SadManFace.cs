using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadManFace : MonoBehaviour {

	private SpriteRenderer rend;
	private float timeBtwSwap;
	public float startTimeBtwSwap;
	public Sprite[] faces;

	void Start(){
		rend = GetComponent<SpriteRenderer>();
	}

	void Update(){
		if(timeBtwSwap <= 0){
			int rand = Random.Range(0, faces.Length);
			rend.sprite = faces[rand];
			timeBtwSwap = startTimeBtwSwap;
		} else {
			timeBtwSwap -= Time.deltaTime;
		}
	}
}
