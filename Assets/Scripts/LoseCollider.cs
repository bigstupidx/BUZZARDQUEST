using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D trigger)
    {
		if(trigger.tag == "Player"){
        
			Scene currentScene = SceneManager.GetActiveScene ();
			string scenename = currentScene.name;
			SceneManager.LoadScene (scenename);
		}}

}