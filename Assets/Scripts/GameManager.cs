using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //declaring variables
    public InputField nameInput;

    private string userName;

    //this method starts at the main menu and will carry the player pref through the game.
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void OnSubmit()
    {
        //set the user name to text in the name input feild
        userName = nameInput.text;

        //display user name
        Debug.Log("You entered  " + userName);
    }

}
