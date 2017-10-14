using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class bowFire : MonoBehaviour {

    public Animator k;
    public GameObject a;

    void Update() {

        if (CnInputManager.GetButtonDown("Fire3")) {
            Instantiate(a, this.transform.position, this.transform.rotation);
        }
    }

	
}
