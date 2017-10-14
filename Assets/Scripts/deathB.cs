using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class deathB : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
			if (Advertisement.IsReady())
			{
			Debug.Log ("k");
				Advertisement.Show();
			}

	}

}
