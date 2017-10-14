using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {

	public int value;


	void OnTriggerEnter2D(Collider2D p){
		if (p.tag == "Player") {
			PlayerPrefs.SetInt("money",PlayerPrefs.GetInt("money")+value);
			Destroy (this.gameObject);
		
		}
	}
}
