using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Movement : MonoBehaviour
{


    //game files
    public GameObject player;
    private Rigidbody2D playerRb;
    private Animator animator;
    public GameObject w;
    

	public bool facingRight=true;
    //touching ground? 
    public bool grounded = true;



    void Start()
    {
        //rigidbody
        playerRb = GetComponent<Rigidbody2D>();
        //animator
        animator = GetComponent<Animator>();
        //walk animation

    }
	void Update(){
		if (grounded==false){
			if (playerRb.velocity.x > 10) {
				float y = playerRb.velocity.y;
				playerRb.velocity = new Vector2 (PlayerPrefs.GetFloat ("playerSpeed") * 10, y);
			}
		}
	}


    void FixedUpdate()
    {
		

        //left right jump movement movement
        if (CnInputManager.GetAxis("Horizontal")>0)
        {
            moveRight();
        }
        if (CnInputManager.GetAxis("Horizontal")<0)
        {
            moveLeft();
        }
        if (CnInputManager.GetButtonDown("Jump"))
        {
            jump();
        }
        //stop
        if (playerRb.velocity.x == 0)
        {
            stopPlayer();
        }
		if (CnInputManager.GetButtonDown("Jump")&&playerRb.velocity.x == 0)
		{
			sjump();
		}

    }
    //movement methods
    void moveRight()
    {
		facingRight = true;
		animator.SetBool("w", true);
		player.transform.localScale = new Vector3(1, 1, 1);
		if (grounded) {
			float y = playerRb.velocity.y;
			playerRb.velocity =new Vector2 (PlayerPrefs.GetFloat("playerSpeed") * 11,y);
		
		}
		if (grounded == false) {
			float y = playerRb.velocity.y;
			playerRb.velocity = new Vector2 (PlayerPrefs.GetFloat ("playerSpeed") * 6, y);
		}
    }

    void moveLeft()
    {
		facingRight = false;
        animator.SetBool("w", true);
        player.transform.localScale = new Vector3(-1, 1, 1);
		if (grounded) {
			float y = playerRb.velocity.y;
			playerRb.velocity =new Vector2 (-PlayerPrefs.GetFloat("playerSpeed") * 11,y);

		}
		if (grounded == false) {
			float y = playerRb.velocity.y;
			playerRb.velocity = new Vector2 (-PlayerPrefs.GetFloat ("playerSpeed") * 6, y);
		}

    }

    void stopPlayer()
    {
        playerRb.velocity = new Vector2(0, 0);
        animator.SetBool("w", false);
    }

    void jump()
    {
        if (grounded)
        {

            animator.SetBool("w", false);
            Vector2 move = new Vector2(0,PlayerPrefs.GetFloat("jumpHeight")* 8);
			playerRb.AddForce(move,ForceMode2D.Impulse);

        }
    }


	void sjump()
	{
		if (grounded)
		{
			if (facingRight) {
				float y = playerRb.velocity.y;
				playerRb.velocity =new Vector2 (PlayerPrefs.GetFloat("playerSpeed") * 0.1f,y);
				animator.SetBool ("w", false);
				Vector2 move = new Vector2 (0, PlayerPrefs.GetFloat ("jumpHeight") * 8f);
				playerRb.AddForce (move, ForceMode2D.Impulse);
			}

			if (facingRight == false) {
				float y = playerRb.velocity.y;
				playerRb.velocity =new Vector2 (-PlayerPrefs.GetFloat("playerSpeed") * 0.1f,y);
				animator.SetBool ("w", false);
				Vector2 move = new Vector2 (0, PlayerPrefs.GetFloat ("jumpHeight") * 8f);
				playerRb.AddForce (move, ForceMode2D.Impulse);
			}
		}
	}
}
