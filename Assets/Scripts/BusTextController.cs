using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BusTextController : MonoBehaviour {

    //public variables
    public Text gameText;

    //private variables for enum
    private enum State { bus, tryAgain, bus2, busSecondTry };
    private State myState;

	// Use this for initialization
	void Start () {
        myState = State.bus;
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == State.bus)
        {
            state_bus();
        }
        else if(myState == State.tryAgain)
        {
            state_tryAgain();
        }
        else if(myState == State.bus2)
        {
            state_bus2();
        }
        else if (myState == State.busSecondTry)
        {
            state_busSecondTry();
        }
	}

    void state_bus()
    {
        gameText.text = "Rocket: We made it to the 49! There are lots of people standing here at this bus stop, I bet they’re all waiting for the bus too." +
                        "It doesn’t look like there’s a line. Do you know what to do when the bus gets here? Oh, look! The 49!" +
                        "It’s waiting at the red light and will be here soon!\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": As the bus arrives, I should Push forward through the crowd of people so I can be the first one on the bus," +
                        "even if people are trying to get off. (Press the P key)\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": As the bus arrives, I should Wait where I am standing and move safely to the bus," +
                        "only when everyone on the bus has gotten off first. (Press the W key)";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = State.tryAgain;
        } else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = State.bus2;
        }
    }

    void state_tryAgain()
    {
        gameText.text = "Rocket:  That’s not quite right! Etiquette, or the way we are kind to others in public," +
                        "tells us that the people who have been waiting longer than we have get to be on the bus first." +
                        "We should wait. And, anyone who is coming off of the bus should be able to get off first, before we get on.\n\n" +
                        "Press the T key to Try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = State.busSecondTry;
        }
    }

    void state_busSecondTry()
    {
        gameText.text = "Rocket: We made it to the 49! There are lots of people standing here at this bus stop, I bet they’re all waiting for the bus too." +
                        "It doesn’t look like there’s a line. Do you know what to do when the bus gets here? Oh, look! The 49!" +
                        "It’s waiting at the red light and will be here soon!\n\n" +
                        "" + PlayerPrefs.GetString("Name") + ": As the bus arrives, I should Wait where I am standing and move safely to the bus," +
                        "only when everyone on the bus has gotten off first. (Press the W key)";
        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = State.bus2;
        }
    }

    void state_bus2()
    {
        gameText.text = "Rocket:  That’s right! Etiquette, or the way we are kind to others in public," +
                        "tells us that people who have been waiting longer get to get on the bus first and we should always wait for others to leave before we get on." +
                        "That doesn’t apply to just buses!\n\n" +
                        "Press the Right Arrow key to advance";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleEndGame");
        }
    }

}//end of script

//Will Fisher
//Last Worked On 12/2/2017
