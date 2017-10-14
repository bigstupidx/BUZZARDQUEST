using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackBox : MonoBehaviour {
	public float damage = 10;


	void OnTriggerEnter2D(Collider2D dam){
		if (dam.gameObject.tag == "Player") {
			PlayerPrefs.SetFloat ("playerHealth", PlayerPrefs.GetFloat ("playerHealth") - damage);
		}
	}


}
