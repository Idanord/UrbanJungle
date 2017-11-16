using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //declaring variables
    public InputField name;

    //this method starts at the main menu and will carry the player pref through the game.
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start () {
        name.text = 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
