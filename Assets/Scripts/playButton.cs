using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playButton : MonoBehaviour {

	public Button b;
	void Update () {
		if (PlayerPrefs.HasKey ("gameSaved") !=true) {
			b.interactable = false;
		} else {
			b.interactable = true;
		}
	}
}
