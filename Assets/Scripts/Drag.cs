using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField]
    BasicCarClass playerCar, opponentCar;
    [SerializeField]
    bool raceIsFinished = false;

    private void Start()
    {
        playerCar.StartYourEngines();
        opponentCar.StartYourEngines();

        StartRace();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!raceIsFinished)
            {
                if (playerCar.currentGear == playerCar.maxGear)
                {
                    EndRace();
                    raceIsFinished = true;
                }
                else
                {
                    playerCar.ShiftRoll();
                    Debug.Log("You're going " + playerCar.totalSpeed + " mph!");
                    opponentCar.ShiftRoll();
                    Debug.Log("Your opponent is going " + opponentCar.totalSpeed + " mph!");
                }
            }
            else if (raceIsFinished)
            {
                raceIsFinished = false;

                playerCar.StartYourEngines();
                opponentCar.StartYourEngines();

                StartRace();
            }
        }
    }

    void StartRace() 
    {
        Debug.Log("Welcome to Roll Drag Testing!");
        Debug.Log("Press Space to begin the race!");
    }

    void EndRace() 
    {
        Debug.Log("The race is finished!");
        Debug.Log("You achieved a top speed of " + playerCar.totalSpeed + " mph!");
        Debug.Log("Your opponent achieved a top speed of " + opponentCar.totalSpeed + " mph!");
        PlayerInfo.instance.totalRaces++;
        if (playerCar.totalSpeed > opponentCar.totalSpeed)
        {
            PlayerInfo.instance.timesWon++;
            Debug.Log("You won the race!");
        }
        else if (playerCar.totalSpeed < opponentCar.totalSpeed)
        {
            PlayerInfo.instance.timesLost++;
            Debug.Log("Your opponent won the race.");
        }
        else if (playerCar.totalSpeed == opponentCar.totalSpeed)
        {
            PlayerInfo.instance.timesDraw++;
            Debug.Log("It's a draw.");
        }
        Debug.Log("Press Space to play again.");
    }
}
