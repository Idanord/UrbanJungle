using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StreetTextController : MonoBehaviour {

    //pulbic variables
    public Text gameText;

    //private variables for enum
    private enum State { streetCrossing, tryAgain, tryAgain2, streetCrossing2, streetCrossing3, accrossStreet };
    private State myState;

	// Use this for initialization
	void Start () {
        myState = State.streetCrossing;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == State.streetCrossing)
        {
            state_streetCrossing();
        }
        else if(myState == State.tryAgain)
        {
            state_tryAgain();
        }
        else if (myState == State.tryAgain2)
        {
            state_tryAgain2();
        }
        else if(myState == State.streetCrossing2)
        {
            state_streetCrossing2();
        }
        else if (myState == State.streetCrossing3)
        {
            state_streetCrossing3();
        }
        else if (myState == State.accrossStreet)
        {
            state_accrossStreet();
        }
	}

    void state_streetCrossing()
    {
        gameText.text = "Rocket: Let’s be careful when we’re crossing the street! We don’t want to get injured. What’s the best way to cross the street?\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Run as soon as there is a break in the cars! (Press the R key)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Push the button even though someone else pushed it a moment before, and wander through the crowd, close to the cars. (Press the P key)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Notice if someone has pressed the button or if the machine is saying, “wait,” which means someone else has pushed the button already." +
                        "Then cross the street slowly, being respectful of the people around you. (Press the C key)";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = State.tryAgain;
        } else if (Input.GetKeyDown(KeyCode.P))
        {
            myState = State.tryAgain2;
        } else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = State.accrossStreet;
        }
    }

    void state_tryAgain()
    {
        gameText.text = "Rocket:  That sounds super dangerous! Maybe there’s something around here that will let us know when to walk?\n\n" +
                        "Press the T key to Try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = State.streetCrossing2;
        }
    }

    void state_streetCrossing2()
    {
        gameText.text = "Rocket: Let’s be careful when we’re crossing the street! We don’t want to get injured. What’s the best way to cross the street?\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Push the button even though someone else pushed it a moment before, and wander through the crowd, close to the cars. (Press the P key)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Notice if someone has pressed the button or if the machine is saying, “wait,” which means someone else has pushed the button already." +
                        "Then cross the street slowly, being respectful of the people around you. (Press the C key)";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = State.tryAgain2;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = State.accrossStreet;
        }
    }

    void state_tryAgain2()
    {
        gameText.text = "Rocket: Even if you’re in a crowd, it can be dangerous to others to be rude and dangerous when crossing the street.\n\n" +
                        "Press the T key to Try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = State.streetCrossing3;
        }
    }

    void state_streetCrossing3()
    {
        gameText.text = "Rocket: Let’s be careful when we’re crossing the street! We don’t want to get injured. What’s the best way to cross the street?\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": Notice if someone has pressed the button or if the machine is saying, “wait,” which means someone else has pushed the button already." +
                        "Then cross the street slowly, being respectful of the people around you. (Press the C key)";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = State.accrossStreet;
        }
    }

    void state_accrossStreet()
    {
        gameText.text = "Rocket:  You are so polite, name! I love going to the park with you.\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleBus");
        }
    }

}//end of script

//Will Fisher
//Last Worked On 12/2/2017
