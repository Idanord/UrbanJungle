using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;           //Do not remove this line or line 4. If these are missing please let me know -WF
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {

    //publically exposing the gameText varible
    public Text gameText;
    //setting the Enum for states
    private enum States { comic, guide, rocket1, rocket2, rocket3, rocket4, rocket5, rocket6, rocket7, transit, transit2, transit3, street, street2,
        comic1, comic2, comic3, comic4, tryagain, tryagain2 };        //Place new states here in the {} brackets
    //States from enum varible
    private States myState;

    // Use this for initialization
    void Start() {
        myState = States.guide;
    }

    // Update is called once per frame
    void Update() {
        //Print out what state the player is in to the console
        print(myState);

        //Checking to see what the state is.
        if (myState == States.guide)
        {
            state_guide();
        }
        //moves the player to the Bus state
        else if (myState == States.rocket1)
        {
            state_rocket1();
        }
        else if (myState == States.rocket2)
        {
            state_rocket2();
        }
        else if (myState == States.transit)
        {
            state_transit();
        }
        else if (myState == States.transit2)
        {
            state_transit2();
        }
        else if (myState == States.transit3)
        {
            state_transit3();
        }
        else if (myState == States.rocket3)
        {
            state_rocket3();
        }
        else if (myState == States.rocket4)
        {
            state_rocket4();
        }
        else if (myState == States.rocket5)
        {
            state_rocket5();
        }
        else if (myState == States.street)
        {
            state_street();
        } else if (myState == States.comic)
        {
            state_comic();
        } else if (myState == States.street2)
        {
            state_street2();
        } else if (myState == States.rocket6)
        {
            state_rocket6();
        } else if (myState == States.rocket7)
        {
            state_rocket7();
        } else if (myState == States.comic1)
        {
            state_comic1();
        } else if (myState == States.comic2)
        {
            state_comic2();
        } else if (myState == States.tryagain)
        {
            state_tryagain();
        } else if (myState == States.comic3)
        {
            state_comic3();
        } else if (myState == States.tryagain2)
        {
            state_tryagain2();
        } else if(myState == States.comic4)
        {
            state_comic4();
        }
    }

    void state_guide() {
        gameText.text = "Say hello to your friendly guide, Rocket the Fish!" +
                        "Rocket will guide you to your friends through the urban jungle of Capitol Hill." +
                        "They’ll offer as many helpful hints as you need, but you’ll have to make some choices along the way!\n\n" +
                        "Rocket: Hi! I’m Rocket! Nice to meet you name. Did you have a fun time at school today?\n\n" +
                        "Player: Yes I did! (Press Y for Yes)   Player: No, not today. (Press N for No)";

        //Pressing the B key will send the player to the bus text
        if (Input.GetKeyDown(KeyCode.Y)) {
            myState = States.rocket1;
        } else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.rocket2;
        }
    }

    void state_rocket1()
    {
        gameText.text = "Rocket: Hurray! I love to have fun at school too.\n\n" +
                        "Press the Right Arrow key.";

        //Pressing the R key Returns the Player to the road
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            myState = States.transit;
        }
    }

    void state_rocket2()
    {
        gameText.text = "Rocket: Oh no, I’m sorry to hear that, name. But tomorrow is a brand new day!\n\n" +
                        "Press the Right Arrow key.";

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.transit;
        }
    }

    void state_transit()
    {
        gameText.text = "Rocket: Are you ready to go to the park and meet your friends?" +
                        "It’s a long way in the big city, but it’ll be super fun. First, let’s get on the streetcar!\n\n" +
                        "Press the Right Arrow key.";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = States.transit2;
        }
    }

    void state_transit2()
    {
        gameText.text = "I love the streetcar.\n\n Did you remember to tap your ORCA card?" +
                        "Player: Yes! (Press Y for Yes)\n\n     Player: Oh no, I forgot. (Press N for No)";

        if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = States.transit3;
        }else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.rocket3;
        }
    }

    void state_transit3()
    {
        gameText.text = "Rocket:  [beep beep!] It’s important to tap your ORCA card whenever you get on any transit." +
                        "What would you do if you didn’t have enough money to cover the fare?\n\n" +
                        "Player:  Get on the streetcar anyway. (Press S to get on the streetcar)\n\n" +
                        "Player: Ask an adult for help to add more money to my ORCA card. (Press H to ask for help)";
        if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.rocket5;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.rocket4;
        }

    }

    void state_rocket3()
    {
        gameText.text = "Rocket: Not so fast! You’ll want to make sure to let an adult know that you don’t have enough fare to cover the trip.\n\n" +
                        "Player: Ask an adult for help to add more money to my ORCA card. (Press H to ask for help)";
        if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.rocket5;
        }
    }


    void state_rocket4()
    {
        gameText.text = "That’s okay! Always make sure to tap your ORCA card when getting on any public transit." +
                        "Fare officers sometimes get on board to check and make sure you’ve paid." +
                        "You may not see them every time, but you should always tap your card just in case! Look for the yellow pads on columns.\n\n" +
                        "Press O to get off the streetcar.";
        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.street;
        }
    }

    void state_rocket5()
    {
        gameText.text = "Rocket: It’s important to ask for help with any purchase like adding more money to your ORCA card.\n\n" +
                        "Press O to get off the streetcar.";
        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.street;
        }
    }
    
    void state_street()
    {
        gameText.text = "Rocket: Okay name, do you want to get on the bus now to meet your friends, or go to the comic book store first?\n\n" +
                        "Player: I love to go to the comic book store!(Press C to go to the Comic book store)\n\n" +
                        "Player: No thank you, not today.(Press N for No)";
        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.comic;
        } else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.street2;
        }
    }

    void state_comic()
    {
        gameText.text = "Rocket:  Yay! Me too! I want to get a new copy of Fishbowl Quarterly." +
                        "Press the Right Arrow key to head to the comic shop.";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            state_comic1();
        }
    }

    void state_comic1()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Pick it up. (Press the Up Arrow)\n\n" +
                        "Player: Ignore it, go inside the store, and forget about it. (Press I to ignore)\n\n" +
                        "Player: Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            state_comic2();

        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            state_comic3();

        }
        else if (Input.GetKeyDown(KeyCode.S))
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
            state_tryagain();
        }
    }

    void state_tryagain()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Ignore it, go inside the store, and forget about it. (Press I to ignore)\n\n" +
                        "Player: Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";
        if (Input.GetKeyDown(KeyCode.I))
        {
            state_comic3();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            state_comic4();
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

    void state_tryagain2()
    {
        gameText.text = "Rocket: Make sure to look both ways before crossing the street!I love going to Phoenix Comics." +
                        "They’re always so nice to me there.Did you know they do game events nearly every night of the… uh oh!" +
                        "Is that a needle on the ground? What do we do?\n\n" +
                        "Player: Notice where it is, go inside the store, and tell an adult. (Press the S key to go into the Store)";

        if (Input.GetKeyDown(KeyCode.S))
        {
            state_comic4();
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


    void state_street2()
    {
        gameText.text = "No worries. Maybe you would like to go to the candy store instead?\n\n" +
                        "Player: Yes please! (Press Y for Yes)      Player:  Not today, I don’t have enough allowance. I’m ready to go meet my friends! (Press N for No)";
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = States.rocket6;
        } else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.rocket7;
        }
    }

    void state_rocket6()
    {
        gameText.text = "Rocket: Hurray! Let’s go!\n\n" +
                        "Press the Right Arrow key to head to the candy store";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleTextCandy");
        }
    }

    void state_rocket7()
    {
        gameText.text = "Rocket: Let’s go!\n\n" +
                        "Press the Right Arrow key to continue on the street.";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("UrbanJungleTextNeedle");
        }
    }

    
}
//end of script
//Will Fisher
//Last worked on 11/18/2017