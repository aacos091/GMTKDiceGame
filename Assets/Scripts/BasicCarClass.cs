using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCarClass : MonoBehaviour
{
    public int currentGear;
    public int maxGear = 6;
    public int totalSpeed;

    int firstGearSpeed = 0;
    int secondGearSpeed = 0;
    int thirdGearSpeed = 0;
    int fourthGearSpeed = 0;
    int fifthGearSpeed = 0;
    int sixthGearSpeed = 0;

    [SerializeField]
    int firstGearMultiplier, secondGearMultiplier, thirdGearMultiplier, fourthGearMultiplier, fifthGearMultiplier, sixthGearMultiplier;

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
                    firstGearSpeed = RollDice() * firstGearMultiplier;
                    totalSpeed += firstGearSpeed;
                    break;
                case 1:
                    secondGearSpeed = RollDice() * secondGearMultiplier;
                    totalSpeed += secondGearSpeed;
                    break;
                case 2:
                    thirdGearSpeed = RollDice() * thirdGearMultiplier;
                    totalSpeed += thirdGearSpeed;
                    break;
                case 3:
                    fourthGearSpeed = RollDice() * fourthGearMultiplier;
                    totalSpeed += fourthGearSpeed;
                    break;
                case 4:
                    fifthGearSpeed = RollDice() * fifthGearMultiplier;
                    totalSpeed += fifthGearSpeed;
                    break;
                case 5:
                    sixthGearSpeed = RollDice() * sixthGearMultiplier;
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
