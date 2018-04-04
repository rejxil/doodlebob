using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public Transform platform; 

	// Update is called once per frame
	void Update () {

		//we want to check if our target's y value is greater than the camera's y value. 
		//camera only follows doodle when he moves upwards
		if (target.position.y > transform.position.y) {

			Vector3 newPos = new Vector3(0f, target.position.y, -10f);
			transform.position = newPos;
			//transform.position = new Vector3 (transform.position.x, target.position.y, target.position.z); //for some reason this doesn't work for me

		}
		
	}
}
