using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour {
    public GameObject healthbar;


    void Start()
    {
        
    }


    void Update () {

        float x = (PlayerPrefs.GetFloat("playerHealth") / PlayerPrefs.GetFloat("playerMaxHealth"));


        healthbar.transform.localScale = new Vector3(x, 1, 1);


	}
}
