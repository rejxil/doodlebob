using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //to ensure that there will always be a Rigidbody component on the gameobject

public class Player : MonoBehaviour {

	public float movementSpeed = 10f;

	//reference to our Rigidbody2D
	Rigidbody2D rb;

	float movement = 0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
