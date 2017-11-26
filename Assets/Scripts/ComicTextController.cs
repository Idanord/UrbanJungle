using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComicTextController : MonoBehaviour {

    //publically exposing the gameText varible
    public Text gameText;
    //setting the Enum for states
    private enum States { comic1, comic2, comic3, comic4, comic5 };        //Place new states here in the {} brackets
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
        } else if(myState == States.comic2)
        {
            state_comic2();
        } else if (myState == States.comic3)
        {
            state_comic3();
        } else if(myState == States.comic4)
        {
            state_comic4();
        }
    }

    void state_comic1()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n"+
                        "Player: Pick it up. (Press the Up Arrow)\n\n" +
                        "Player: Ignore it, go inside the store, and forget about it. (Press I to ignore)\n\n" +
                        "Player: Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            state_comic2();

        } else if (Input.GetKeyDown(KeyCode.I))
        {
            state_comic3();

        } else if (Input.GetKeyDown(KeyCode.S))
        {
            state_comic4();

        }

    }

    void state_comic2()
    {
        gameText.text = "Rocket:  No way! Sharp needles (sharps) are hazardous. They may be bright and colorful, but they’re not for children." +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T Key to try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            state_comic1();
        }
    }

    void state_comic3()
    {
        gameText.text = "Rocket: Although they seem like trash because they’re abandoned on the ground," +
                        "sharp needles (sharps) are hazardous, especially where there are lots of people walking around." +
                        "Maybe we should tell an adult?\n\n" +
                        "Press the T key to try again";
        if (Input.GetKeyDown(KeyCode.T))
        {
            state_comic1();
        }
    }

    void state_comic4()
    {
        gameText.text = "Rocket:  They were so grateful we let them know about the sharp needles (sharps) out in front." +
                        "Now they can carefully clean them up or let the city authorities know. Good work!\n\n" +
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
