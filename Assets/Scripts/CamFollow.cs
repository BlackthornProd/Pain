using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

	public Transform player;
	public float speed;

	void Update(){
		Vector3 pos = new Vector3(player.position.x, transform.position.y, transform.position.z);
		transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
	}
}
