using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour {
	


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (PlayerPrefs.GetFloat("playerHealth") <= 0 )
        {
			Debug.Log ("k");
            SceneManager.LoadScene("Death");
           	PlayerPrefs.SetFloat("playerHealth", PlayerPrefs.GetFloat("playerMaxHealth"));
        }
        }



	}