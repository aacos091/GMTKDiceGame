using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    [SerializeField]int totalSpeed, firstGearSpeed, secondGearSpeed, thirdGearSpeed, fourthGearSpeed, fifthGearSpeed, sixthGearSpeed;

    enum Gears
    {
        firstGear,
        secondGear,
        thirdGear,
        fourthGear,
        fifthGear,
        sixthGear
    }

    [SerializeField]Gears currentGear;
    [SerializeField]int gear;

    private void Start()
    {
        StartRace();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gear <= 6) 
        {
            shiftGears();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && gear > 6) 
        {
            StartRace();
        }
    }

    int rollDice() 
    {
        int rollResult = Random.Range(1, 7);
        return rollResult;
    }

    void shiftGears() 
    {
        switch (currentGear)
        {
            case Gears.firstGear:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gear++;
                    firstGearSpeed = rollDice() * 10;
                    totalSpeed += firstGearSpeed;
                    Debug.Log("You're going " + totalSpeed + " mph!");
                    Debug.Log("Press Space to roll!");
                    currentGear = Gears.secondGear;
                }
                break;
            case Gears.secondGear:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gear++;
                    secondGearSpeed = rollDice() * 8;
                    totalSpeed += secondGearSpeed;
                    Debug.Log("You're going " + totalSpeed + " mph!");
                    Debug.Log("Press Space to roll!");
                    currentGear = Gears.thirdGear;
                }
                break;
            case Gears.thirdGear:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gear++;
                    thirdGearSpeed = rollDice() * 6;
                    totalSpeed += thirdGearSpeed;
                    Debug.Log("You're going " + totalSpeed + " mph!");
                    Debug.Log("Press Space to roll!");
                    currentGear = Gears.fourthGear;
                }
                break;
            case Gears.fourthGear:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gear++;
                    fourthGearSpeed = rollDice() * 4;
                    totalSpeed += fourthGearSpeed;
                    Debug.Log("You're going " + totalSpeed + " mph!");
                    Debug.Log("Press Space to roll!");
                    currentGear = Gears.fifthGear;
                }
                break;
            case Gears.fifthGear:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gear++;
                    fifthGearSpeed = rollDice() * 2;
                    totalSpeed += fifthGearSpeed;
                    Debug.Log("You're going " + totalSpeed + " mph!");
                    Debug.Log("Press Space to roll!");
                    currentGear = Gears.sixthGear;
                }
                break;
            case Gears.sixthGear:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gear++;
                    sixthGearSpeed = rollDice() * 1;
                    totalSpeed += sixthGearSpeed;
                    Debug.Log("You just crossed the finish line going " + totalSpeed + " mph!");
                    Debug.Log("Nice one!");
                    Debug.Log("Press Space to race again.");
                }
                break;
            default:
                break;
        }
    }

    void StartRace() 
    {
        Debug.Log("Welcome to Roll Drag Testing!");
        Debug.Log("Press Space to begin the race!");

        totalSpeed = 0;
        firstGearSpeed = 0;
        secondGearSpeed = 0;
        thirdGearSpeed = 0;
        fourthGearSpeed = 0;
        fifthGearSpeed = 0;
        sixthGearSpeed = 0;

        currentGear = Gears.firstGear;
        gear = 1;
    }
}
