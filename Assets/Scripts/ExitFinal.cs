using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitFinal : MonoBehaviour {



	void OnTriggerStay2D(Collider2D col){

		if (col.tag == "Player") {
			SceneManager.LoadScene ("Credits");
		}
	}
}
