using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSelection : MonoBehaviour {

	public void knight(){
		PlayerPrefs.SetString ("playerClass", "knight");
        PlayerPrefs.SetFloat("playerSpeed", 1);
        PlayerPrefs.SetFloat("jumpHeight", 1);
        PlayerPrefs.SetFloat("playerHealth", 200);
        PlayerPrefs.SetFloat("playerMaxHealth", 200);
        PlayerPrefs.SetFloat("playerDamage", 10);
    }
	public void mage(){
		PlayerPrefs.SetString ("playerClass", "mage");
        PlayerPrefs.SetFloat("playerSpeed", 1);
        PlayerPrefs.SetFloat("jumpHeight", 1);
        PlayerPrefs.SetFloat("playerHealth", 150);
        PlayerPrefs.SetFloat("playerMaxHealth", 150);
        PlayerPrefs.SetFloat("playerDamage", 5);
    }
	public void ninja(){
		PlayerPrefs.SetString ("playerClass", "ninja");
        PlayerPrefs.SetFloat("playerSpeed", 1);
        PlayerPrefs.SetFloat("jumpHeight", 1);
        PlayerPrefs.SetFloat("playerHealth", 75);
        PlayerPrefs.SetFloat("playerMaxHealth", 75);
        PlayerPrefs.SetFloat("playerDamage", 15);
    }
	public void archer(){
		PlayerPrefs.SetString ("playerClass", "archer");
        PlayerPrefs.SetFloat("playerSpeed", 1);
        PlayerPrefs.SetFloat("jumpHeight", 1);
        PlayerPrefs.SetFloat("playerHealth", 100);
        PlayerPrefs.SetFloat("playerMaxHealth", 100);
        PlayerPrefs.SetFloat("playerDamage", 5);
    }


}
