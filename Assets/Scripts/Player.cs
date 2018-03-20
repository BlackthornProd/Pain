using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	private float moveInput;
	public float jumpForce;

	private Rigidbody2D rb;
	private Animator anim;
	public GameObject groundEffect;
	public GameObject trailEffect;
	private bool spawnedEffect;
	private float timeBtwEffect;
	public float startTimeBtwEffect;

	private bool facingRight = false;

	private bool isGrounded = false;
	public Transform groundPos;
	public float checkRadius;
	public LayerMask whatIsGround;


	public bool canMove = true;


	void Start(){
		anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D>();
	}



	void FixedUpdate(){

		isGrounded = Physics2D.OverlapCircle(groundPos.position, checkRadius, whatIsGround);

		if(canMove == true){
			moveInput = Input.GetAxisRaw("Horizontal");
			rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
		} else {
			anim.SetBool("IsMoving", false);
			anim.SetBool("IsJumping", false);
		}
	

		if(moveInput != 0){
			if(timeBtwEffect <= 0){
				Instantiate(trailEffect, transform.position, Quaternion.identity);
				timeBtwEffect = startTimeBtwEffect;
			} else {
				timeBtwEffect -= Time.deltaTime;
			}

			if(canMove == true){
				anim.SetBool("IsMoving", true);
			}
				
			} else if(moveInput == 0){
				anim.SetBool("IsMoving", false);
			}

			if(facingRight == true && moveInput > 0){
				Flip();
			} else if(facingRight == false && moveInput < 0){
				Flip();	
			}

	}

	void Update(){



		if(isGrounded == true && Input.GetKeyDown(KeyCode.UpArrow) && canMove == true){

			rb.velocity = Vector2.up * jumpForce;
		}

		if(isGrounded == false){
			spawnedEffect = false;
			anim.SetBool("IsJumping", true);
		} else {
			if(spawnedEffect == false){
				Instantiate(groundEffect, groundPos.position, Quaternion.identity);
				spawnedEffect = true;
			}
			anim.SetBool("IsJumping", false);
		}
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
