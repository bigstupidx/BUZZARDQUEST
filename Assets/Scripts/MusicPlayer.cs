using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;

    public AudioClip startClip;
    public AudioClip gameClip;
    public AudioClip mapClip;

    private AudioSource music;

    void Start () {
		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            music.clip = startClip;
            music.loop = true;
            music.Play();
		}
		
	}

    private void OnLevelWasLoaded(int level)
    {
        Debug.Log("MusicPlayer: Loaded level " +level);
        //music.Stop(); Unity hates it, commented out in case needed later

        if (level == 0)
        {
            music.clip = startClip;
        }
        if (level == 3)
        {
            music.clip = mapClip;
        }
        if (level >= 4)
        {
            music.clip = gameClip;
        }
        music.loop = true;
        music.Play();
    }
}
