using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthpac : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D c){
		if (c.tag == "Player") {
			if (PlayerPrefs.GetFloat ("playerMaxHealth") != PlayerPrefs.GetFloat ("playerHealth")) {
				PlayerPrefs.SetFloat ("playerHealth", PlayerPrefs.GetFloat ("playerMaxHealth"));
				Destroy (this.gameObject);
			}
		}
	}

}
