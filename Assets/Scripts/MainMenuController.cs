using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //Required when using UI elements
using UnityEngine.SceneManagement;      //Required when using Scene Management

public class MainMenuController : MonoBehaviour {

    /*//initializing Variables
    public InputField name;*/

    

    private string userName, PlayerName;

    // Use this for initialization
    void Start () {

        
        //Adds a listener to the main input field and invokes a method when the value changes
        //name.onValueChanged.AddListener(delegate { ValueChangedCheck(); });

	}
	
	// Update is called once per frame
	void Update () {
		
	}

   /*//Invoide when the value of the text vield changes.
    public void ValueChangedCheck()
    {
        Debug.Log("Value Changed");
    }*/
    /*
    public void SaveUserName(string newName)
    {
        userName = newName;
    }
    */
    public void StartGame()
    {
        //PlayerName = nameInput.text;
        //PlayerPrefs.SetString("NAME", PlayerName);
        //Debug.Log("PlayerName variable now holds: " + PlayerName + " PlayerPrefs now is " + PlayerPrefs.GetString("NAME"));
        //SetPlayerName(PlayerName);
        //Debug.Log("In Menu controller and passing this name to SPN: " + PlayerName);
        SceneManager.LoadScene("UrbenJungleText");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    /*public void nameCarry()
    {
        //set the user name to text in the name input feild
        userName = nameInput.text;
        //userName = nameInput.GetComponent<InputField>().text;
        //display user name
        Debug.Log("You entered " + userName);
    }*/
}

//Will Fisher
//Last Worked On 11/12/2017
