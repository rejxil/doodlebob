using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePlatform : LevelGenerator {

	public GameObject prefabPlatform;

	public int nop = 10; //number of platforms for our levels 
	public float widthLevel = 3f;
	public float bottomY = 10f; 
	public float topY = 20f;

	// Use this for initialization
	void Start () {
		Vector3 positionSpawn = new Vector3 ();
		for (int i = 0; i < nop; i++) 
		{
			positionSpawn.y += Random.Range (bottomY, topY);
			positionSpawn.x = Random.Range (-widthLevel, widthLevel); 
			Instantiate (prefabPlatform, positionSpawn, Quaternion.identity); //(Quaternion.identity means we won't rotate the object at all)
		}
	}
}