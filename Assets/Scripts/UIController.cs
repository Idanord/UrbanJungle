using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public InputField nameInput;

    private string playerName;

    public void OnSubmit()
    {
        playerName = nameInput.text;

        Debug.Log("You selected " + nameInput);
    }
    
    /*
    public static InputField nameInput;

    public static string SetPlayerName(string value) {
        //playerName.text = value;
        string PlayerName = value;

        string otherName = nameInput.text;
        //PlayerPrefs.SetString(PlayerName,value);
        PlayerPrefs.SetString("NAME", PlayerName);
        PlayerPrefs.SetString("OTHERNAME", otherName);
        string name = PlayerPrefs.GetString("NAME");
        string oName = PlayerPrefs.GetString("OTHERNAME");
        Debug.Log("PlayerName variable now holds: " + name + " " + oName);
        return PlayerName;
    }
*/

}
