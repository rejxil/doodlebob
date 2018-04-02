using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour {

	public float jumpForce = 10f; 

	void OnCollisionEnter2D(Collision2D collision)
	{
		Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();
		//only allows collider and rigidbody to collide with each other 
		if (rb != null) {
			//Velocity will be the result of the force of bouncing upwards
			//sets speed we want doodle to travel upwards after bouncing
			Vector2 velocity = rb.velocity;
			velocity.y = jumpForce; 
			rb.velocity = velocity;
		}
	}
}
