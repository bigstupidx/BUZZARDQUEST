using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSystem : MonoBehaviour {


    public GameObject c;
    public Text t;
	public bool destroyOnStart;
	public int time;

	void Update(){
		if(destroyOnStart){
			Invoke ("d",time);
		}
	}




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player") {
            c.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            c.SetActive(false);
        }
    }

	void d (){
		Destroy (t.gameObject);
		Destroy (this.gameObject);
		
		
		
	}


}
