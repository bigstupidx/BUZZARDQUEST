using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public void deleteSave(){
		PlayerPrefs.DeleteAll ();
		PlayerPrefs.DeleteKey ("gameSaved");
	}

	public void PauseMenuOpen ()
	{
		PlayerPrefs.SetInt ("pauseMenu", 1);
	}
	public void PauseMenuClose ()
	{
		PlayerPrefs.SetInt ("pauseMenu", 0);
	}
    public void LoadLevel(string name)
    {
		PlayerPrefs.SetFloat("playerHealth", PlayerPrefs.GetFloat("playerMaxHealth"));
        SceneManager.LoadScene(name);   
	}
	public void LoadFromMenu(string name)
	{
		if (PlayerPrefs.HasKey ("gameSaved") == true) {
			PlayerPrefs.SetFloat ("playerHealth", PlayerPrefs.GetFloat ("playerMaxHealth"));
			SceneManager.LoadScene (name);   
		} else {
			SceneManager.LoadScene ("characterSelection");
		}

	}
    public void QuitRequest()
    {
        Application.Quit();
    }
	public void Add50()
	{
		PlayerPrefs.SetInt ("money",PlayerPrefs.GetInt("money")+50);
	}


}