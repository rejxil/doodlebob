using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {

	public float jumpForce = 10f; 

	public Sprite platform; 
	public Sprite brokenPlatform;

	private SpriteRenderer spriteRenderer;

	void Start() {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (spriteRenderer.sprite == null)
			spriteRenderer.sprite = platform;
	}

	public void OnCollisionEnter2D(Collision2D coll)
	{

		//upward force being applied due to 2D effector but no collision is actually happening
		//therefore we need to check if object is coming from above or from below

		if (coll.relativeVelocity.y <= 0) {

			Rigidbody2D rb = coll.collider.GetComponent<Rigidbody2D> ();
			//only allows collider and rigidbody to collide with each other 
			if (rb != null) {
				Vector2 velocity = rb.velocity;
				velocity.y = jumpForce; 
				rb.velocity = velocity;
				ChangeSprite ();
				Destroy (GetComponent<EdgeCollider2D> ());
			}
		}
	}

	void ChangeSprite() {
		if (spriteRenderer.sprite == platform) {
			spriteRenderer.sprite = brokenPlatform;
		} 
	}
}
