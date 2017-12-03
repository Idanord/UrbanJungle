using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameTextController : MonoBehaviour {

    //public variables
    public Text gameText;

    //private variables for enum
    private enum State { endGame, tag, hop, everyone, finalAnswer, finalAnswer2 };
    private State myState;

	// Use this for initialization
	void Start () {
        myState = State.endGame;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == State.endGame)
        {
            state_endGame();
        }
        else if (myState == State.tag)
        {
            state_tag();
        }
        else if (myState == State.hop)
        {
            state_hop();
        }
        else if (myState == State.everyone)
        {
            state_everyone();
        }
        else if (myState == State.finalAnswer)
        {
            state_finalAnswer();
        }
        else if (myState == State.finalAnswer2)
        {
            state_finalAnswer2();
        }
	}

    void state_endGame()
    {
        gameText.text = "Rocket: I love the 49 bus! I can’t wait to get to the park to meet your friends! What kind of games will we play once we get there?\n\n" +
                        "Player: I want to play Tag with my friends! (Press the T key)" +
                        "Player: I want to play Hop-schotch with my firends! (Press the H key)" +
                        "Player: I'm not sure. I'll see what Everyone wants to play when we get there. (Press the E key)";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = State.tag;
        } else if (Input.GetKeyDown(KeyCode.H))
        {
            myState = State.hop;
        } else if (Input.GetKeyDown(KeyCode.E))
        {
            myState = State.everyone;
        }
    }

    void state_tag()
    {
        gameText.text = "Rocket: That sounds great. I like tag. Do you think everyone else will want to play?\n\n" +
                        "Player: I think they will. (Press the Y key)" +
                        "Player: I don't think everyone will play tag. (Press the N key)";
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = State.finalAnswer;
        } else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = State.finalAnswer2;
        }
    }

    void state_hop()
    {
        gameText.text = "Rocket: I like to play hop-schotch. Do you think everyone else will want to play?\n\n" +
                        "Player: I think they will. (Press the Y key)" +
                        "Player: I don't think everyone will play hop-scotch. (Press the N key)";
        if (Input.GetKeyDown(KeyCode.Y))
        {
            myState = State.finalAnswer;
        } else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = State.finalAnswer2;
        }
    }

    void state_everyone()
    {
        gameText.text = "Rocket: That sounds great. We can play what will make everyone happy.\n\n" +
                        "Press the Right Arrow to advance.";
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            myState = State.finalAnswer;
        }
    }

    void state_finalAnswer()
    {
        gameText.text = "Rocket: Everyone loves to play games. I know that they will want to play with you.\n\n" +
                        "Press the Q key to end the game";
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Credits");
        }
    }

    void state_finalAnswer2()
    {
        gameText.text = "Rocket: It's best to play something that will make everyone happy.\n\n" +
                        "Press the Q key to end the game";
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Credits");
        }
    }
    
}//end of script

//Will Fisher
//Last Worked On 12/2/2017
