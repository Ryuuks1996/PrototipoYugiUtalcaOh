using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    PlayerController player;
    PlayerController enemy;

    States currentState;

    bool useCheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum States
    {
        gameStar, gamePause, 
        phase1, phase2, phase3, phase4, phase5, phase6
    }
    
    void Phase1()
    {

        player.drawCard();
        currentState = States.phase2;
    }

    void Phase2()
    {
        if (useCheck)
        {
           
        }
        currentState = States.phase3;
    }
    void Phase3()
    {
        if (!useCheck)
        {

        }
        currentState = States.phase4;
    }

    void Phase4()
    {
        if (!useCheck)
        {

        }
        currentState = States.phase5;
    }
    void Phase5()
    {
        if (!useCheck)
        {

        }
        currentState = States.phase6;
    }
    void Phase6()
    {
        if (!useCheck)
        {

        }
        currentState = States.gamePause;
    }

    void GamePause()
    {
        currentState = States.gameStar;
    }

    void useCard()
    {
    
    }
}
