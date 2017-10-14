using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {

	public string nextLevel;


	void OnTriggerStay2D(Collider2D col){

		if (col.tag == "Player") {
			PlayerPrefs.SetInt(nextLevel, 1);
			SceneManager.LoadScene ("Map");
		}
		}
}
