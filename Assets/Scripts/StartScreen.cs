using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {



	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Space)) {
			StartGame();
		}
	}

	public void StartGame () {
		Application.LoadLevel ("Level1");
	}

	public void QuitGame () {
		Application.Quit();
	}
}