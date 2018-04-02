using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyPlatform : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 10; //number of platforms for our levels 
	public float levelWidth = 3f;
	public float minY = 50f; 
	public float maxY = 50f;

	// Use this for initialization
	void Start () {
		Vector3 spawnPosition = new Vector3 ();
		for (int i = 0; i < numberOfPlatforms; i++) 
		{
			spawnPosition.y += Random.Range (minY, maxY);
			spawnPosition.x = Random.Range (-levelWidth, levelWidth); 
			Instantiate (platformPrefab, spawnPosition, Quaternion.identity); //(Quaternion.identity means we won't rotate the object at all)
		}
	}
}