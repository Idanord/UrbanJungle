using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NeedleTextController : MonoBehaviour {

    //public variables
    public Text gameText;

    //private variables for enum
    private enum States { needle1, needle2, tryAgain, needle3, tryAgain2, needle4 };
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.needle1;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.needle1)
        {
            state_needle1();
        }
        else if (myState == States.needle2)
        {
            state_needle2();
        }
        else if (myState == States.tryAgain)
        {
            state_tryAgain();
        }
        else if(myState == States.needle3)
        {
            state_needle3();
        }
        else if(myState == States.tryAgain2)
        {
            state_tryAgain2();
        }
        else if(myState == States.needle4)
        {
            state_needle4();
        }
	}

    void state_needle1()
    {
        gameText.text = "Rocket: We can only take the 49 bus to get to the park, but...uh oh! Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Pick it up. (Press the Up Arrow key)\n\n" +
                        "Player: Ignore it and wait for the bus. (Press the I key)\n\n" +
                        "Player: Notice where it is, go inside a nearby store, and tell an adult. (Press the S key)";
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myState = States.needle2;
        } else if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.needle3;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.needle4;
        }
    }

    void state_needle2()
    {
        gameText.text = "Rocket:  No way! Sharp needles (sharps) are hazardous. They may be bright and colorful, but they’re not for children.\n" +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T Key to try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tryAgain;
        }
    }

    void state_tryAgain()
    {
        gameText.text = "Rocket: We can only take the 49 bus to get to the park, but...uh oh! Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Ignore it and wait for the bus. (Press the I key)\n\n" +
                        "Player: Notice where it is, go inside a nearby store, and tell an adult. (Press the S key)";
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.needle3;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.needle4;
        }
    }

    void state_needle3()
    {
        gameText.text = "Rocket: Although they seem like trash because they’re abandoned on the ground," +
                        "sharp needles (sharps) are hazardous, especially where there are lots of people walking around." +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T key to try again";

        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tryAgain2;
        }
    }

    void state_tryAgain2()
    {
        gameText.text = "Rocket: We can only take the 49 bus to get to the park, but...uh oh! Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Notice where it is, go inside a nearby store, and tell an adult. (Press the S key)";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.needle4;
        }
    }

    void state_needle4()
    {
        gameText.text = "Rocket:  They were so grateful we let them know about the sharp needles (sharps) out in front." +
                        "Now they can carefully clean them up or let the city authorities know. Good work!\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleStreet");
        }
    }
}//end of script

//Will Fisher
//Last Worked on 12/2/2017
