using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobDetect : MonoBehaviour {
	public GameObject blob;
	private blobMove move;
	void Start (){
		move = GetComponentInParent<blobMove> ();
	}


	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			move.detected = true;
		}
	}
	void OnTriggerStay2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			move.detected = true;
		}
	}
	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.tag == "Player") {
			move.detected = false;
		}
	}
}
