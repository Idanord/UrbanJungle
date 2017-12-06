using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
    /*
    pupublic InputField nameInt;
    public static string playerName;

    void OnSubmit()
    {
        nameInput.text = playerName;
        Debug.Log("You selected " + playerName);
    }
    */
    /*
    public static InputField nameInput;

    public void SetPlayerName(string value) {
        //playerName.text = value;
        string PlayerName = value;

 
        //PlayerPrefs.SetString(PlayerName,value);
        PlayerPrefs.SetString("NAME", PlayerName);
//PlayerPrefs.SetString("OTHERNAME", otherName);
        string name = PlayerPrefs.GetString("NAME");
        //string oName = PlayerPrefs.GetString("OTHERNAME");
        Debug.Log("PlayerName variable now holds: " + name );
        
    }
*/
    //rename inputfield for clarification
    public InputField namePlayer;
    public static string m_PlayerName;
    //Added Start on value change to Name Input
    public void Start()
    {        
        m_PlayerName = namePlayer.text;
    }
    //Added Update to on end edit on Name Input
    public void Update()
    {
        PlayerPrefs.SetString("Name", m_PlayerName);
    }

}
