using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {



	public void OnCollisionEnter2D(Collision2D collision)
	{

		//upward force being applied due to 2D effector but no collision is actually happening
		//therefore we need to check if object is coming from above or from below

		if (collision.relativeVelocity.y <= 0) {

			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D> ();
			//only allows collider and rigidbody to collide with each other 
			if (rb != null) {

			}
				
			Destroy (gameObject);

		}
	}
}
