using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

	private Animator anim;
	public GameObject death;
	private Player player;
	public GameObject deathFX;

	void Start(){
		player = GetComponent<Player>();
		anim = GetComponent<Animator>();
	}

	public void Death(){
		Instantiate(deathFX, transform.position, Quaternion.identity);
		anim.SetTrigger("Death");
		death.SetActive(true);
		player.canMove = false;
		Debug.Log(player.canMove);
		
	}
}
