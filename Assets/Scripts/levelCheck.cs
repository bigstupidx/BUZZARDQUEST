using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using CnControls;
using UnityEngine.UI;


public class levelCheck : MonoBehaviour {
	public string levelName;
	public string levelNameDisplay;
	public GameObject button;
    public Text t;
    //opens the level
    void OnTriggerStay2D (Collider2D col){
		
		button.SetActive (true);

		if (CnInputManager.GetButtonDown ("Fire1")) {
			SceneManager.LoadScene(levelName);
		}

	}
	void OnTriggerEnter2D (Collider2D col){
		
		button.SetActive (true);

		if (CnInputManager.GetButtonDown ("Fire1")) {
			SceneManager.LoadScene(levelName);
        }
		t.text = levelNameDisplay;
        t.enabled = true;
    }
	void OnTriggerExit2D (Collider2D col){
		button.SetActive (false);
        t.enabled = false;
    }

}
