using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField Name;
    public string UserName;
    void Update()
    {
        UserName = (Name.text);
        PlayerPrefs.SetString("PlayersName", UserName);
        Debug.Log(UserName);
    }
}
