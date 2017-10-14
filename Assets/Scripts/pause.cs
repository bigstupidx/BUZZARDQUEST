using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {

	//opens pause menu and closes game
	public GameObject panel;
	public GameObject player;
	public GameObject touchcontrols;


	void Update () {
		if (PlayerPrefs.GetInt("pauseMenu") == 1) {
			panel.SetActive (true);
			player.SetActive (false);
			touchcontrols.SetActive (false);
		}
		if (PlayerPrefs.GetInt("pauseMenu") == 0) {
			panel.SetActive (false);
			player.SetActive (true);
			touchcontrols.SetActive (true);
		}
	
	
	
	}
}
