using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGenerator : MonoBehaviour {

	public GameObject platformPrefab;

	public int numberOfPlatforms = 20; //number of platforms for our levels 
	public float levelWidth = 3f;
	public float minY = 1f; 
	public float maxY = 3.2f;
	float currentTop;

	// Use this for initialization
	void Start () {
		Vector3 spawnPosition = new Vector3 ();
		for (int i = 0; i < numberOfPlatforms; i++) 
		{
			spawnPosition.y += Random.Range (minY, maxY);
			spawnPosition.x = Random.Range (-levelWidth, levelWidth); 
			GameObject platform = Instantiate (platformPrefab, spawnPosition, Quaternion.identity); //(Quaternion.identity means we won't rotate the object at all)

			PlatformScript ps = platform.GetComponent<PlatformScript> ();
			if (ps != null)
				ps.SetGenerator(this);
		}
		currentTop = spawnPosition.y;
		//Debug.Log (currentTop);
	}

	public void MovePlatform(Transform platform)
	{
		currentTop += Random.Range (minY, maxY);
		//Debug.Log (currentTop);
		Vector3 pos = platform.position;

		pos.y = currentTop;
		pos.x = Random.Range (-levelWidth, levelWidth); 

		platform.position = pos;
	}
}
