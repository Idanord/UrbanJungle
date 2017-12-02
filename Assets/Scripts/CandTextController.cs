using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CandTextController : MonoBehaviour {
    
    //public variables
    public Text gameText;

    //Private variables for states
    private enum States { candy1, candy2, tryAgain, candy3, tryAgain2, candy4 };
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.candy1;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.candy1)
        {
            state_candy1();
        }
        else if(myState == States.candy2)
        {
            state_candy2();
        }
        else if(myState == States.tryAgain)
        {
            state_tryAgain();
        }
        else if(myState == States.candy3)
        {
            state_candy3();
        }
        else if (myState == States.tryAgain2)
        {
            state_tryAgain2();
        }
        else if(myState == States.candy4)
        {
            state_candy4();
        }
	}

    void state_candy1()
    {
        gameText.text = "Rocket: I love RocketFizz! They have all , but...uh oh! Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Pick it up. (Press the Up Arrow)\n\n" +
                        "Player: Ignore it, go to the store, and forget about it. (Press the I key)\n\n" +
                        "Player: Notice where it is, go inside a nearby store, and tell an adult. (Press the S key)";
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myState = States.candy2;
        } else if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.candy3;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.candy4;
        }
    }

    void state_candy2()
    {
        gameText.text = "Rocket:  No way! Sharp needles (sharps) are hazardous. They may be bright and colorful, but they’re not for children.\n\n" +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T Key to try again.";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tryAgain;
        }
    }

    void state_tryAgain()
    {
        gameText.text = "Rocket: I love RocketFizz! They have all , but...uh oh! Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Ignore it, go to the store, and forget about it. (Press the I key)\n\n" +
                        "Player: Notice where it is, go inside a nearby store, and tell an adult. (Press the S key)";
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.candy3;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.candy4;
        }
    }

    void state_candy3()
    {
        gameText.text = "Rocket: Although they seem like trash because they’re abandoned on the ground, sharp needles (sharps) are hazardous," +
                        "especially where there are lots of people walking around. Maybe we should tell an adult?\n\n" +
                        "Press the T Key to try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tryAgain2;
        }
    }

    void state_tryAgain2()
    {
        gameText.text = "Rocket: I love RocketFizz! They have all , but...uh oh! Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Notice where it is, go inside a nearby store, and tell an adult. (Press the S key)";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.candy4;
        }
    }

    void state_candy4()
    {
        gameText.text = "Rocket:  They were so grateful we let them know about the sharp needles (sharps) out in front." +
                        "Now they can carefully clean them up or let the city authorities know. Good work!\n\n" +
                        "Press the Right Arrow key to advance.";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleStreet");
        }
    }
}//end of script

//Will Fisher
//Last Worked On 12/2/2017
