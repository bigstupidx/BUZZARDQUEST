using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{

	private Animator anim;
    private Movement player;



    void Start()
    {
        player = gameObject.GetComponentInParent<Movement>();
		anim = GetComponentInParent<Animator> ();
	}


    void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;
		anim.SetBool("j", false);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        player.grounded = true;
		anim.SetBool("j", false);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
		anim.SetBool("j", true);
    }




}
