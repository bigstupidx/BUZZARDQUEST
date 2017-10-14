using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class SwordAttack : MonoBehaviour {

    public GameObject sword;
    public GameObject bow;
    public GameObject knife;
    public GameObject staff;
    public Animator b;
    public Animator sw;
    public Animator k;
    public Animator st;
    public Collider2D c;

    void Start() {
        
        if (PlayerPrefs.GetString("playerClass") == "knight") {
            sword.SetActive(true);
            bow.SetActive(false);
            knife.SetActive(false);
            staff.SetActive(false);
        }
        if (PlayerPrefs.GetString("playerClass") == "ninja")
        {
            sword.SetActive(false);
            bow.SetActive(false);
            knife.SetActive(true);
            staff.SetActive(false);
        }
        if (PlayerPrefs.GetString("playerClass") == "mage")
        {
            sword.SetActive(false);
            bow.SetActive(false);
            knife.SetActive(false);
            staff.SetActive(true);
        }
        if (PlayerPrefs.GetString("playerClass") == "archer")
        {
            sword.SetActive(false);
            bow.SetActive(true);
            knife.SetActive(false);
            staff.SetActive(false);
        }

    }



    void Update() {
        if (CnInputManager.GetButton("Fire3")) {
            sw.SetBool("a", true);
            b.SetBool("a", true);
			k.SetBool ("a",true);
            if (PlayerPrefs.GetString("playerClass") == "knight") {
                c.enabled = true;
            }
             
            Invoke("kstop", 1f);
            Invoke("stop",0.01f);
        }




    }
    void stop() {
        sw.SetBool("a", false);
        b.SetBool("a", false);
		k.SetBool ("a",false);
    }

    void kstop()
    {
        if (PlayerPrefs.GetString("playerClass") == "knight")
        {
            c.enabled = false;
        }

    }








}
