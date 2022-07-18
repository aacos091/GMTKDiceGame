using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField]
    BasicCarClass playerCar, opponentCar;
    [SerializeField]
    public bool raceIsFinished = false;

    public GameObject playerCarSprite;
    public GameObject opponentCarSprite;

    float playerCarDistance;
    float opponentCarDistance;

    Vector3 playerCarPosition;
    Vector3 opponentCarPosition;

    private void Start()
    {
        backToStartingLine();

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
                    raceIsFinished = true;
                    EndRace();
                }
                else
                {
                    playerCar.ShiftRoll();
                    Debug.Log("You're going " + playerCar.totalSpeed + " mph!");
                    opponentCar.ShiftRoll();
                    Debug.Log("Your opponent is going " + opponentCar.totalSpeed + " mph!");
                    checkPosition();
                }
            }
            else if (raceIsFinished)
            {
                raceIsFinished = false;

                backToStartingLine();

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
            playerCarPosition = new Vector3(3.0f, 1.2f);
            opponentCarPosition = new Vector3(-3.0f, -0.5f);
            Debug.Log("You won the race!");
        }
        else if (playerCar.totalSpeed < opponentCar.totalSpeed)
        {
            PlayerInfo.instance.timesLost++;
            playerCarPosition = new Vector3(-3.0f, 1.2f);
            opponentCarPosition = new Vector3(3.0f, -0.5f);
            Debug.Log("Your opponent won the race.");
        }
        else if (playerCar.totalSpeed == opponentCar.totalSpeed)
        {
            PlayerInfo.instance.timesDraw++;
            playerCarPosition = new Vector3(0f, 1.2f);
            opponentCarPosition = new Vector3(0f, -0.5f);
            Debug.Log("It's a draw.");
        }
        Debug.Log("Press Space to play again.");
    }

    void backToStartingLine() 
    {
        playerCarPosition = new Vector3(0f, 1.2f);
        opponentCarPosition = new Vector3(0f, -0.5f);

        playerCarDistance = 0f;
        opponentCarDistance = 0f;

        playerCarSprite.transform.position = playerCarPosition;
        opponentCarSprite.transform.position = opponentCarPosition;
    }

    void checkPosition() 
    {
        if (playerCar.totalSpeed > opponentCar.totalSpeed)
        {
            playerCarDistance--;
            opponentCarDistance++;
            playerCarPosition = new Vector3(playerCarDistance, 1.2f);
            opponentCarPosition = new Vector3(opponentCarDistance, -0.5f);
            playerCarSprite.transform.position = playerCarPosition;
            opponentCarSprite.transform.position = opponentCarPosition;
        }
        else if (playerCar.totalSpeed < opponentCar.totalSpeed)
        {
            playerCarDistance++;
            opponentCarDistance--;
            playerCarPosition = new Vector3(playerCarDistance, 1.2f);
            opponentCarPosition = new Vector3(opponentCarDistance, -0.5f);
            playerCarSprite.transform.position = playerCarPosition;
            opponentCarSprite.transform.position = opponentCarPosition;
        }
    }
}
