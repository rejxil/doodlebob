using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformScript : MonoBehaviour {

	public float jumpForce = 10f; 

	void OnCollisionEnter2D(Collision2D collision)
	{

		Debug.Log("Collision detected!");
		//upward force being applied due to 2D effector but no collision is actually happening
		//therefore we need to check if object is coming from above or from below

		//this means that we are coming
		if (collision.relativeVelocity.y <= 0) {

			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();
			//only allows collider and rigidbody to collide with each other 
			if (rb != null) {
				//Velocity will be the result of the force of bouncing upwards
				//sets speed we want doodle to travel upwards after bouncing
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce; 
				rb.velocity = velocity;
			}

			LevelGenerator.currentScore += 10;
			Destroy (gameObject);

		}
	}

}
