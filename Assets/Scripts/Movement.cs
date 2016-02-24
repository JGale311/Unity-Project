using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


	public bool controllable = true;

	public float speed = 7.0f;
	public float jumpSpeed = 6.0f;
	public float gravity = 20.0f;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	void Start()
	{
		controller = GetComponent<CharacterController> ();
	}

	void Update()
	{
		if (controller.isGrounded && controllable)

		{
			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

			if (Input.GetButton ("Jump"))
				moveDirection.y = jumpSpeed;

		}


		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}

}
