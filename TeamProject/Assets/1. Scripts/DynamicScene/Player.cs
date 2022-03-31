using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Animator anim;
	private CharacterController controller;

	public float speed = 5f;
	public float turnSpeed = 150f;
	private Vector3 moveDirection = Vector3.zero;
	public float gravity = 3.71f;
	public float jumpSpeed = 3.5f;

	float directionY;


	void Start ()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		controller = GetComponent <CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
	}

	void Update (){
		if (Input.GetKey ("w") || Input.GetKey("s")) {
			anim.SetInteger ("AnimationPar", 1);
		}  else {
			anim.SetInteger ("AnimationPar", 0);
		}

		if (controller.isGrounded){
			moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;

			if (Input.GetButtonDown("Jump"))
			{
				directionY = jumpSpeed;
				anim.SetBool("Jump", true);
			}
			else
				anim.SetBool("Jump", false);
		}

		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
		controller.Move(moveDirection * Time.deltaTime);
		directionY -= gravity * Time.deltaTime;
		moveDirection.y = directionY;
	}
}
