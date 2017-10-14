using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSet : MonoBehaviour {

	public Animator anim;
	private SpriteRenderer player;
	public Sprite knight;
	public Sprite archer;
	public Sprite mage;
	public Sprite ninja;
	public bool k;
	public bool a;
	public bool m;
	public bool n;


	void Start (){
		player = GetComponent<SpriteRenderer> ();

	}
		
	void Update (){
		if (PlayerPrefs.GetString ("playerClass") == "knight"||k) {
			player.sprite = knight;
			anim.SetBool ("knight",true);
			anim.SetBool ("archer",false);
			anim.SetBool ("mage",false);
			anim.SetBool ("ninja",false);
            PlayerPrefs.SetString("playerClass", "knight");
        }
		if (PlayerPrefs.GetString ("playerClass") == "archer"||a) {
			player.sprite = archer;
			anim.SetBool ("knight",false);
			anim.SetBool ("archer",true);
			anim.SetBool ("mage",false);
			anim.SetBool ("ninja",false);
            PlayerPrefs.SetString("playerClass", "archer");
        }
		if (PlayerPrefs.GetString ("playerClass") == "ninja"||n) {
			player.sprite = ninja;
			anim.SetBool ("knight",false);
			anim.SetBool ("archer",false);
			anim.SetBool ("mage",false);
			anim.SetBool ("ninja",true);
            PlayerPrefs.SetString("playerClass", "ninja");
        }
		if (PlayerPrefs.GetString ("playerClass") == "mage"||m) {
			player.sprite = mage;
			anim.SetBool ("knight",false);
			anim.SetBool ("archer",false);
			anim.SetBool ("mage",true);
			anim.SetBool ("ninja",false);
            PlayerPrefs.SetString("playerClass", "mage");
        }
	} 




}
