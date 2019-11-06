using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InformationController : MonoBehaviour {

    public Text infoText;

    private enum States {moveForward};

    private States infoState;

    void Start()
    {
        infoState = States.moveForward;
    }

    private void Update()
    {
        if(infoState == States.moveForward)
        {
            moveForward();
        }  
    }

    // Use this for initialization
    void moveForward()
    {
        infoText.text = "Welcome to Urban Jungle, a choose-your-own-adventure game about Capitol Hill in Seattle!" +
            "Urban Jungle Game asks you to make decisions about social situations in your urban environment." +
            "You’ll learn to spot the difference between safe and unsafe situations and how to respect strangers around you," +
            "while you travel after school down Broadway Ave E to 10th Ave and to Roanoke Park to play with your friends!\n\n" +
            "Press the Right Arrow key to move forward";

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
