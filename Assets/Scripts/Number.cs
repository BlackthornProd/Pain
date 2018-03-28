using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour {


	public float minSize;
	public float maxSize;
	private SpriteRenderer rend;
	public Sprite[] numbers;

	void Start(){

		rend = GetComponent<SpriteRenderer>();
		int randNum = Random.Range(0, numbers.Length);
		rend.sprite = numbers[randNum];

		transform.localScale = new Vector3(Random.Range(minSize, maxSize), Random.Range(minSize, maxSize), 1);
	}
}
