using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("kills") >= 3) {
			PlayerPrefs.SetInt ("playerLevel", 1);
		}
		if (PlayerPrefs.GetInt ("kills") >= 6) {
			PlayerPrefs.SetInt ("playerLevel", 2);
		}
		if (PlayerPrefs.GetInt ("kills") >= 12) {
			PlayerPrefs.SetInt ("playerLevel", 3);
		}
		if (PlayerPrefs.GetInt ("kills") >= 18) {
			PlayerPrefs.SetInt ("playerLevel", 4);
		}
		if (PlayerPrefs.GetInt ("kills") >= 20) {
			PlayerPrefs.SetInt ("playerLevel", 5);
		}
	}
}
