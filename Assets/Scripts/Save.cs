using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour {


	//set the variables to anything you want
    public bool manualOverdrive = false;



	void Start () {


        if (PlayerPrefs.HasKey("gameSaved") == false  )
        {
			Debug.Log ("A New Game Was Loaded!");
            PlayerPrefs.SetInt("gameSaved", 0);
            //initial variables
			PlayerPrefs.SetInt("playerLevel", 1);
            PlayerPrefs.SetInt("pauseMenu", 0);
            PlayerPrefs.SetInt("kills", 0);
            PlayerPrefs.SetInt("money", 0);
            PlayerPrefs.SetFloat("playerX", -548);
            PlayerPrefs.SetFloat("playerY", -1);
			PlayerPrefs.SetFloat("playerSpeed", 1);
			PlayerPrefs.SetFloat("jumpHeight", 1);

			// level scripts
			PlayerPrefs.SetInt("level1", 1);
			PlayerPrefs.SetInt("level2", 0);
			PlayerPrefs.SetInt("level3", 0);
			PlayerPrefs.SetInt("level4", 0);
			PlayerPrefs.SetInt("level5", 0);
			PlayerPrefs.SetInt("level6", 0);
			PlayerPrefs.SetInt("level7", 0);
			PlayerPrefs.SetInt("level8", 0);
			PlayerPrefs.SetInt("level9", 0);
			PlayerPrefs.SetInt("level10", 0);
        }
        else {
            PlayerPrefs.SetFloat("playerHealth", 100);
            PlayerPrefs.SetFloat("playerMaxHealth", 100);
            PlayerPrefs.SetFloat("playerDamage", 10);
        }


	}




    void Update()
    {
        //level 1 stats
        if (PlayerPrefs.GetInt("playerLevel") == 1) {
            if (PlayerPrefs.GetString("playerClass") == "knight")
            {
                PlayerPrefs.SetFloat("playerMaxHealth", 150);
                PlayerPrefs.SetFloat("playerDamage", 4);
            }
            if (PlayerPrefs.GetString("playerClass") == "archer" )
            {
                PlayerPrefs.SetFloat("playerMaxHealth", 115);
                PlayerPrefs.SetFloat("playerDamage", 3);
            }
            if (PlayerPrefs.GetString("playerClass") == "ninja")
            {
                PlayerPrefs.SetFloat("playerMaxHealth", 75);
                PlayerPrefs.SetFloat("playerDamage", 6);
            }
            if (PlayerPrefs.GetString("playerClass") == "mage" )
            {
                PlayerPrefs.SetFloat("playerMaxHealth", 90);
                PlayerPrefs.SetFloat("playerDamage", 5);
            }
        }

	
		//level 2 stats
		if (PlayerPrefs.GetInt("playerLevel") == 2) {
			if (PlayerPrefs.GetString("playerClass") == "knight")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 185);
				PlayerPrefs.SetFloat("playerDamage", 9);
			}
			if (PlayerPrefs.GetString("playerClass") == "archer" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 145);
				PlayerPrefs.SetFloat("playerDamage", 6);
			}
			if (PlayerPrefs.GetString("playerClass") == "ninja")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 115);
				PlayerPrefs.SetFloat("playerDamage", 12);
			}
			if (PlayerPrefs.GetString("playerClass") == "mage" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 175);
				PlayerPrefs.SetFloat("playerDamage", 10);
			}
		}
	
		//level 3 stats
		if (PlayerPrefs.GetInt("playerLevel") == 3) {
			if (PlayerPrefs.GetString("playerClass") == "knight")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 225);
				PlayerPrefs.SetFloat("playerDamage", 12);
			}
			if (PlayerPrefs.GetString("playerClass") == "archer" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 185);
				PlayerPrefs.SetFloat("playerDamage", 10);
			}
			if (PlayerPrefs.GetString("playerClass") == "ninja")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 145);
				PlayerPrefs.SetFloat("playerDamage", 18);
			}
			if (PlayerPrefs.GetString("playerClass") == "mage" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 200);
				PlayerPrefs.SetFloat("playerDamage", 15);
			}
		}
	
		//level 4 stats
		if (PlayerPrefs.GetInt("playerLevel") == 4) {
			if (PlayerPrefs.GetString("playerClass") == "knight")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 275);
				PlayerPrefs.SetFloat("playerDamage", 18);
			}
			if (PlayerPrefs.GetString("playerClass") == "archer" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 200);
				PlayerPrefs.SetFloat("playerDamage", 13);
			}
			if (PlayerPrefs.GetString("playerClass") == "ninja")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 160);
				PlayerPrefs.SetFloat("playerDamage", 24);
			}
			if (PlayerPrefs.GetString("playerClass") == "mage" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 225);
				PlayerPrefs.SetFloat("playerDamage", 20);
			}
		}
	
		//level 5 stats
		if (PlayerPrefs.GetInt("playerLevel") == 5) {
			if (PlayerPrefs.GetString("playerClass") == "knight")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 300);
				PlayerPrefs.SetFloat("playerDamage", 22);
			}
			if (PlayerPrefs.GetString("playerClass") == "archer" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 250);
				PlayerPrefs.SetFloat("playerDamage", 18);
			}
			if (PlayerPrefs.GetString("playerClass") == "ninja")
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 185);
				PlayerPrefs.SetFloat("playerDamage", 30);
			}
			if (PlayerPrefs.GetString("playerClass") == "mage" )
			{
				PlayerPrefs.SetFloat("playerMaxHealth", 225);
				PlayerPrefs.SetFloat("playerDamage", 25);
			}
		}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	}
}
