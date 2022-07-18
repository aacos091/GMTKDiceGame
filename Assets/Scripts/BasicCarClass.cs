using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCarClass : MonoBehaviour
{
    public int currentGear;
    public int maxGear = 6;
    public int totalSpeed;

    public int firstGearSpeed = 0;
    public int secondGearSpeed = 0;
    public int thirdGearSpeed = 0;
    public int fourthGearSpeed = 0;
    public int fifthGearSpeed = 0;
    public int sixthGearSpeed = 0;

    [SerializeField]
    public int firstGearMultiplier, secondGearMultiplier, thirdGearMultiplier, fourthGearMultiplier, fifthGearMultiplier, sixthGearMultiplier;

    public int firstRoll, secondRoll, thirdRoll, fourthRoll, fifthRoll, sixthRoll;

    public void StartYourEngines() 
    {
        currentGear = 0;

        totalSpeed = 0;

        firstGearSpeed = 0;
        secondGearSpeed = 0;
        thirdGearSpeed = 0;
        fourthGearSpeed = 0;
        fifthGearSpeed = 0;
        sixthGearSpeed = 0;
    }

    public void ShiftRoll() 
    {
        if (currentGear <= maxGear)
        {
            switch (currentGear)
            {
                case 0:
                    firstRoll = RollDice();
                    firstGearSpeed = firstRoll * firstGearMultiplier;
                    totalSpeed += firstGearSpeed;
                    break;
                case 1:
                    secondRoll = RollDice();
                    secondGearSpeed = secondRoll * secondGearMultiplier;
                    totalSpeed += secondGearSpeed;
                    break;
                case 2:
                    thirdRoll = RollDice();
                    thirdGearSpeed = thirdRoll * thirdGearMultiplier;
                    totalSpeed += thirdGearSpeed;
                    break;
                case 3:
                    fourthRoll = RollDice();
                    fourthGearSpeed = fourthRoll * fourthGearMultiplier;
                    totalSpeed += fourthGearSpeed;
                    break;
                case 4:
                    fifthRoll = RollDice();
                    fifthGearSpeed = fifthRoll * fifthGearMultiplier;
                    totalSpeed += fifthGearSpeed;
                    break;
                case 5:
                    sixthRoll = RollDice();
                    sixthGearSpeed = sixthRoll * sixthGearMultiplier;
                    totalSpeed += sixthGearSpeed;
                    break;
                default:
                    break;

            }
            currentGear++;
        }
    }

    int RollDice() // This is a seperate function, hopefully i can add in some kind of animation
    {
        return Random.Range(1, 7);
    }
}
