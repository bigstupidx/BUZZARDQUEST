using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitBox : MonoBehaviour {

    public GameObject b;
    public float health = 20;
    public float maxHealth = 20;
	public int coins;
	public bool boss;
	public GameObject coin;
	public Text t;

    void Start() {

    }




    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "PWeapon") {
            health = health - PlayerPrefs.GetFloat("playerDamage");
        }
    }

    void Update() {
		if (health <= 0) {
			if (boss) {
				Instantiate(coin, this.transform.position, this.transform.rotation);
				t.enabled = true;
				Destroy (b);
			} else {
				Destroy (b);
				PlayerPrefs.SetInt ("kills", PlayerPrefs.GetInt ("kills") + 1);
				PlayerPrefs.SetInt ("money", PlayerPrefs.GetInt ("money") + coins);
			}
		}


    }
		
		
}
