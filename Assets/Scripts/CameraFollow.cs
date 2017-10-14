using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class CameraFollow : MonoBehaviour {

	private Camera cam;

	public GameObject player;

	private Vector3 offset;

    bool camSizeBig = false;


	void Start () {
		offset = transform.position - player.transform.position;
		cam = GetComponent<Camera> ();
	}

	void Update () {


        if (CnInputManager.GetButtonDown ("q")) {
            if (camSizeBig)
            {
                cam.orthographicSize = (5);
                camSizeBig = false;
            }
            if (camSizeBig==false)
            {
                cam.orthographicSize = (2);
                camSizeBig = true;
            }



        }
		


	}

	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
