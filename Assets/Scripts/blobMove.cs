using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blobMove : MonoBehaviour {

	public float speed =2;
	public GameObject blob;
	private Rigidbody2D move;
	public GameObject player;
	public bool detected;
	public float scale = 1;
	void Start (){
		move = GetComponent<Rigidbody2D> ();
		blob.transform.localScale = new Vector3(1*scale, 1*scale, 1*scale);

	}

	void FixedUpdate(){
		if (detected) {
			Detected ();
		} else {
			stop ();
		}
		Physics2D.IgnoreCollision (this.GetComponent<BoxCollider2D> (), player.GetComponent<PolygonCollider2D>());


	}
		
	void Detected (){
		if (player.transform.position.x > blob.transform.position.x) {
			moveRight ();

		}
		if (player.transform.position.x < blob.transform.position.x) {
			moveLeft ();
		}
		if (Mathf.Approximately(player.transform.position.x,blob.transform.position.x)) {
			stop ();
		}
	}



	void moveRight(){
		blob.transform.localScale = new Vector3(1*scale, 1*scale, 1*scale);
		move.velocity =new Vector2 (speed,0);

	}

	void moveLeft(){
		blob.transform.localScale = new Vector3(-1*scale, 1*scale, 1*scale);
		move.velocity =new Vector2 (-speed,0);

	}
	void stop (){
		move.velocity =new Vector2 (0,0);
	}










}
