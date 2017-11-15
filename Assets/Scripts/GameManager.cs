using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //declaring variables
    [HideInInspector]
    public bool gameStartedFromMainMenu;

    //Array of all Scenes in the project
    private string[] Scenes = new string[]
    {
        "FrontEnd", "Credits", "Menu", "UrbenJungleText"
    };


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
