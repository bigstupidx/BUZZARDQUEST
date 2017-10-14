using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour {

	public Text t;


	void Update () {
		t.text = ("$" + PlayerPrefs.GetInt ("money"));
	}
}
