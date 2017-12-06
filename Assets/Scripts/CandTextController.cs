using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CandTextController : MonoBehaviour {
    
    //public variables
    public Text gameText;

    //Private variables for states
    private enum States { candy1, candy2, tryAgain, candy3, tryAgain2, candy4, leavingCandy, leavingCandy2, tryAgain3, tryAgain4, homeless, talkToHomeless };
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
        else if (myState == States.leavingCandy)
        {
            state_leavingCandy();
        }
        else if (myState == States.leavingCandy2)
        {
            state_leavingCandy2();
        }
        else if (myState == States.homeless)
        {
            state_homeless();
        }
        else if (myState == States.tryAgain3)
        {
            state_tryAgain3();
        }
        else if (myState == States.tryAgain4)
        {
            state_tryAgain4();
        }
        else if (myState == States.talkToHomeless)
        {
            state_talkToHomeless();
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
        gameText.text = "Rocket:  No way! Sharp needles (sharps) can be dangerous. They may be bright and colorful, but they’re not for children.\n\n" +
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
        gameText.text = "Rocket: Although they seem like trash because they’re abandoned on the ground, sharp needles (sharps) can be dangerous," +
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
                        "They will know how to safely clean it up. Good work!\n\n" +
                        "Press the Right Arrow key to advance.";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.leavingCandy;
        }
    }

    void state_leavingCandy()
    {
        gameText.text = "Rocket: Yummmmm! They have my favorite soda: Strawberry Shortcake!" +
                        "I’m going to ask my mom to get me some as a special treat some day soon!\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.leavingCandy2;
        }
    }

    void state_leavingCandy2()
    {
        gameText.text = "You pass a homeless person on the street with a sign that says “Homeless. Please help. Thank you. God bless.”\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.homeless;
        }
    }

    void state_homeless()
    {
        gameText.text = "Rocket: Hello there.\n\n" +
                        "Do you Ignore the homeless person entirely and keep walking?\n (Press the I key)\n\n" +
                        "Do you smile and nod along with Rocket but Keep walking?\n (Press the K key)\n\n" +
                        "Do you take a moment to remember if you have any spare Change and ask Rocket to spare some change as well?\n (Press the C key)";
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.tryAgain3;
        } else if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.tryAgain4;
        } else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.talkToHomeless;
        }
    }

    void state_tryAgain3()
    {
        gameText.text = "Rocket: Hello there.\n\n" +
                       "Do you smile and nod along with Rocket but Keep walking?\n (Press the K key)\n\n" +
                       "Do you take a moment to remember if you have any spare Change and ask Rocket to spare some change as well?\n (Press the C key)";
        if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.tryAgain4;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.talkToHomeless;
        }
    }

    void state_tryAgain4()
    {
        gameText.text = "Rocket: Hello there.\n\n" +
                        "Do you take a moment to remember if you have any spare Change and ask Rocket to spare some change as well?\n (Press the C key)";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.talkToHomeless;
        }
    }

    void state_talkToHomeless()
    {
        gameText.text = "Rocket: I would love to help. Here, I have a few quarters, as do you." +
                        "That’s $2. Rocket hands the money to the person. The person says thank you!" +
                        "Thanks for helping that person. It’s always good to offer kindness to strangers when and how you can.\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleStreet");
        }
    }

}//end of script

//Will Fisher
//Last Worked On 12/2/2017
