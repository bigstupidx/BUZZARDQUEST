using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelPlay : MonoBehaviour {

	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;
	public GameObject level6;
	public GameObject level7;
	public GameObject level8;
	public GameObject level9;
	public GameObject level10;

	void Start () {
		level1.SetActive (false);
		level2.SetActive (false);
		level3.SetActive (false);
		level4.SetActive (false);
		level5.SetActive (false);
		level6.SetActive (false);
		level7.SetActive (false);
		level8.SetActive (false);
		level9.SetActive (false);
		level10.SetActive (false);
	}



	void Update () {
		if (PlayerPrefs.GetInt ("level1") == 1) {
			level1.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level2") == 1) {
			level2.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level3") == 1) {
			level3.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level4") == 1) {
			level4.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level5") == 1) {
			level5.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level6") == 1) {
			level6.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level7") == 1) {
			level7.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level8") == 1) {
			level8.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("level9") == 1) {
			level9.SetActive (true);
		}

		if (PlayerPrefs.GetInt ("level10") == 1) {
			if (PlayerPrefs.GetInt ("money") >= 1000) {
				level10.SetActive (true);
			}
		}

	}
}
