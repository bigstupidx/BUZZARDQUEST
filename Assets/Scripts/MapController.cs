using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;


public class MapController : MonoBehaviour {

	public GameObject Player;
	private Rigidbody2D player;
	public float x;
	public float y;

	void Start(){
		player = GetComponent<Rigidbody2D> ();
		x = PlayerPrefs.GetFloat ("playerX");
		y = PlayerPrefs.GetFloat ("playerY");
		Player.transform.position = new Vector3 (x, y, 0);
        
	}



	void FixedUpdate(){
		if (CnInputManager.GetAxis ("Horizontal") > 0) {
			float ay = player.velocity.y;
			player.velocity = new Vector2 (20, ay);
		} 
		if (CnInputManager.GetAxis ("Horizontal") < 0) {
			float ay = player.velocity.y;
			player.velocity = new Vector2 (-20, ay);
		} 
		if (CnInputManager.GetAxis("Horizontal")==0&&CnInputManager.GetAxis("Vertical")==0){
			player.velocity = new Vector2 (0, 0);
		}

	}

	void Update(){
		if (CnInputManager.GetAxis ("Vertical") > 0) {
		float ax = player.velocity.x;
		player.velocity = new Vector2 (ax, 20);
		} 
		if (CnInputManager.GetAxis ("Vertical") < 0) {
		float ax = player.velocity.x;
		player.velocity = new Vector2 (ax, -20);
		}
		x = Player.transform.position.x;
		y = Player.transform.position.y;
		PlayerPrefs.SetFloat ("playerX", x);
		PlayerPrefs.SetFloat ("playerY", y);

	}






}
