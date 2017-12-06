using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComicTextController : MonoBehaviour {

    //publically exposing the gameText varible
    public Text gameText;
    //setting the Enum for states
    private enum States { comic1, comic2, comic3, comic4, comic5, tryagain, tryagain2, leavingComic, leavingComic2, homeless1, tryAgain3, tryAgain4, talkToHomeless };        //Place new states here in the {} brackets
    //States from enum varible
    private States myState;

    // Use this for initialization
    void Start () {
        myState = States.comic1;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.comic1)
        {
            state_comic1();
        } 
		else if(myState == States.comic2)
        {
            state_comic2();
        }
		else if (myState == States.tryagain)
        {
            state_tryagain();
        }
        else if (myState == States.comic3)
        {
            state_comic3();
        }
		else if(myState == States.comic4)
        {
            state_comic4();
        }
        else if(myState == States.tryagain)
        {
            state_tryagain();
        }
        else if(myState == States.tryagain2)
        {
            state_tryagain2();
        }
        else if(myState == States.leavingComic)
        {
            state_leavingComic();
        }
        else if(myState == States.leavingComic2)
        {
            state_leavingComic2();
        }
        else if(myState == States.homeless1)
        {
            state_homeless1();
        }
        else if (myState == States.tryAgain3)
        {
            state_tryAgain3();
        }
        else if (myState == States.tryAgain4)
        {
            state_tryAgain4();
        }
        else if(myState == States.talkToHomeless)
        {
            state_talkToHomeless();
        }
    }

    void state_comic1()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n"+
                        "" + PlayerPrefs.GetString("Name") + ": Pick it up. (Press the Up Arrow to pick it up)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Ignore it, go inside the store, and forget about it. (Press I to ignore)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";

		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myState = States.comic2;

		} else if (Input.GetKeyDown(KeyCode.I))
        {
			myState = States.comic3;

		} else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.comic4;

        }

    }

    void state_comic2()
    {
        gameText.text = "Rocket:  No way! Sharp needles (sharps) can be dangerous. They may be bright and colorful, but they’re not for children." +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T Key to try again";
		if (Input.GetKeyDown(KeyCode.T))
        {
			myState = States.tryagain;
        }
    }

    void state_tryagain()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Ignore it, go inside the store, and forget about it. (Press I to ignore)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";

        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.comic3;
        }
		else if (Input.GetKeyDown(KeyCode.S))
        {
			myState = States.comic4;
        }
    }

    void state_comic3()
    {
        gameText.text = "Rocket: Although they seem like trash because they’re abandoned on the ground," +
                        "sharp needles (sharps) can be dangerous, especially where there are lots of people walking around." +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T key to try again";
		if (Input.GetKeyDown(KeyCode.T))
        {
			myState = States.tryagain2;
        }
    }

    void state_tryagain2()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.comic4;
        }
    }

    void state_comic4()
    {
        gameText.text = "Rocket:  They were so grateful we let them know about the sharp needles (sharps) out in front." +
                        "They will know how to safely clean it up. Good work!\n\n" +
                        "Press the Right Arrow key to advance";
		if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.leavingComic;
        }
    }

    void state_leavingComic()
    {
        gameText.text = "Rocket: I liked that special edition of Fishbowl Quarterly, but it wasn’t something I absolutely needed." +
                        "I like browsing in the store and talking to the people who work there, because they know a lot about one of my favorite things: comics!\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.leavingComic2;
        }
    }

    void state_leavingComic2()
    {
        gameText.text = "You pass a homeless person on the street with a sign that says “Homeless. Please help. Thank you. God bless.”\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.homeless1;
        }
    }

    void state_homeless1()
    {
        gameText.text = "Rocket: Hello there.\n\n" +
                        "Do you ignore the homeless person entirely and keep walking?\n (Press the I key)\n\n" +
                        "Do you smile and nod along with Rocket but keep walking?\n (Press the K key)\n\n" +
                        "Do you take a moment to remember if you have any spare change and ask Rocket to spare some change as well?\n (Press the C key)";
        if (Input.GetKeyDown(KeyCode.I))
        {
            myState = States.tryAgain3;
        } else if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.tryAgain4;
        }else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.talkToHomeless;
        }
    }

    void state_tryAgain3()
    {
        gameText.text = "Rocket: Hello there.\n\n" +
                        "Do you smile and nod along with Rocket but keep walking?\n (Press the K key)\n\n" +
                        "Do you take a moment to remember if you have any spare change and ask Rocket to spare some change as well?\n (Press the C key)";
        if (Input.GetKeyDown(KeyCode.K))
        {
            myState = States.tryAgain4;
        } else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.talkToHomeless;
        }
    }

    void state_tryAgain4()
    {
        gameText.text = "Rocket: Hello there.\n\n" +
                        "Do you take a moment to remember if you have any spare change and ask Rocket to spare some change as well?\n (Press the C key)";
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
}

//end of script
//Will Fisher
//Last Worked On 11/26/2017
