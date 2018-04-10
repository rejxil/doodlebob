using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NormalPlatform : LevelGenerator {

	public static int currentScore;
	public Text displayScore;

	void Update() {
		displayScore.text = "Score: " + currentScore;

		/*
		if (currentScore == 20) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}
		*/
	}

}
