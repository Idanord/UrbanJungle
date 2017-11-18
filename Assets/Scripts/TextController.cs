using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;           //Do not remove this line or line 4. If these are missing please let me know -WF
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {

    //publically exposing the gameText varible
    public Text gameText;
    //setting the Enum for states
    private enum States { guide, rocket1, rocket2, transit };        //Place new states here in the {} brackets
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
        if (myState == States.guide) {
            state_guide();
        }
        //moves the player to the Bus state
        else if (myState == States.bus) {
            state_bus();
        } else if (myState == States.road_1)
        {
            state_road_1();
        } else if (myState == States.shop_0)
        {
            state_shop_0();
        } else if (myState == States.road_2)
        {
            state_road_2();
        } else if (myState == States.road_3)
        {
            state_road_3();
        } else if (myState == States.lightrail)
        {
            state_lightrail();
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

    void state_bus()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the O key to get off the bus.";

        //Pressing the R key Returns the Player to the road
        if (Input.GetKeyDown(KeyCode.O)) {
            myState = States.road_1;
        }
    }

    void state_road_1()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the S key to go into the shop. Or press the W key to continue to walk down the street.";

        //Pressing the S key moves the player into the shop
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.shop_0;
        }
        //Pressing the W key continues the player down the street.
        else if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.road_2;
        }
    }

    void state_shop_0()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the L key to leave the shop.";

        //Pressing the L key moves the player to the road_2 state.
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.road_2;
        }
    }

    void state_road_2()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the W key to walk up the street. Or press the T key to head to the Lightrail.";

        //Pressing the W key moves the player up the road via walking.
        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.road_3;
        }
        //Pressing the T key moves the player to the lightrail state.
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.lightrail;
        }
    }


    //Everything belowe this comment is a work in progress. We need to define what states the player can go into before
    //moving forward.
    void state_road_3()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the W key to walk up the street. Or press the T key to head to the Lightrail.";

        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.road_3;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.lightrail;
        }
    }

    void state_lightrail()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the L key to leave the shop.";

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.road_2;
        }
    }

    void end_game()
    {
        gameText.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, " +
                        "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
                        "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. " +
                        "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. " +
                        "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.\n\n" +
                        "Press the Q key to leave the game";

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Credits");
        }
    }

    
}

//Will Fisher
//Last worked on 10/15/2017