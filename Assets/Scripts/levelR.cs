﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelR : MonoBehaviour {

	void Update () {
		this.GetComponent<Text> ().text = "Level:"+PlayerPrefs.GetInt("playerLevel");
	}
}
