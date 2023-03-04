using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float Speed;
	public Rigidbody2D Rb;
	Vector3 Change;
	public float JumpForce; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Change.x = Input.GetAxisRaw("Horizontal");

		Rb.MovePosition(Rb.transform.position + Change * Speed * Time.deltaTime);
		if (Input.GetButton("jump")) ;
		Debug.Log("jump");


		


	}
}
