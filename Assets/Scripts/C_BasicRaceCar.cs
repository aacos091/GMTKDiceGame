using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_BasicRaceCar : MonoBehaviour
{
    [Serializable]
    public struct CarStats 
    {
        public string carName;
        public int topSpeed;
    }

    [SerializeField]
    private CarStats stats;

    // Name of the character's car
    public string driverName;

    // Creates the total speed variable and the getter for it
    public int totalSpeed;

    // These are used to calculate how much speed you are going through each gear shift
    public int firstGearSpeed, secondGearSpeed, thirdGearSpeed, fourthGearSpeed, fifthGearSpeed, sixthGearSpeed;
    // These are used to multiply to your result every time you do a shift roll
    int firstGearMultiplier, secondGearMultiplier, thirdGearMultiplier, fourthGearMultiplier, fifthGearMultiplier, sixthGearMultiplier;
    public enum Gears // Can either use this or the int down below
    { 
        firstGear,
        secondGear,
        thirdGear,
        fourthGear,
        fifthGear,
        sixthGear
    }
    public Gears currentGear;
    public int i_currentGear; // May not need to use this, needed it for a loop in the first iteration

    public C_BasicRaceCar() 
    {
        totalSpeed = 0;
        firstGearSpeed = 0;
        secondGearSpeed = 0;
        thirdGearSpeed = 0;
        fourthGearSpeed = 0;
        fifthGearSpeed = 0;
        sixthGearSpeed = 0;

        firstGearMultiplier = 10;
        secondGearMultiplier = 8;
        thirdGearMultiplier = 6;
        fourthGearMultiplier = 4;
        fifthGearMultiplier = 2;
        sixthGearMultiplier = 1;

        currentGear = Gears.firstGear;
        i_currentGear = 1;
    }

    public C_BasicRaceCar(string _name) // Instantiates a basic drag car with default variables
    {
        driverName = _name;

        totalSpeed = 0;
        firstGearSpeed = 0;
        secondGearSpeed = 0;
        thirdGearSpeed = 0;
        fourthGearSpeed = 0;
        fifthGearSpeed = 0; 
        sixthGearSpeed = 0;

        firstGearMultiplier = 10;
        secondGearMultiplier = 8;
        thirdGearMultiplier = 6;
        fourthGearMultiplier = 4;
        fifthGearMultiplier = 2; 
        sixthGearMultiplier = 1;

        currentGear = Gears.firstGear;
        i_currentGear = 1;
    }

    // Instantiate a race car with specific gear multipliers, to be used when creating opponents
    public C_BasicRaceCar(int firstGearM, int secondGearM, int thirdGearM, int fourthGearM, int fifthGearM, int sixthGearM, string _name) 
    {
        driverName = _name;

        totalSpeed = 0;
        firstGearSpeed = 0;
        secondGearSpeed = 0;
        thirdGearSpeed = 0;
        fourthGearSpeed = 0;
        fifthGearSpeed = 0;
        sixthGearSpeed = 0;

        firstGearMultiplier = firstGearM;
        secondGearMultiplier = secondGearM;
        thirdGearMultiplier = thirdGearM;
        fourthGearMultiplier = fourthGearM;
        fifthGearMultiplier = fifthGearM;
        sixthGearMultiplier = sixthGearM;

        currentGear = Gears.firstGear;
        i_currentGear = 1;
    }

    int rollDice() 
    {
        int rollResult = UnityEngine.Random.Range(1, 7);
        return rollResult;
    }

    public void ShiftRoll() 
    { 
        switch (currentGear) 
        {
            case Gears.firstGear:
                i_currentGear++;
                firstGearSpeed = rollDice() * firstGearMultiplier;
                totalSpeed += firstGearSpeed;
                currentGear = Gears.secondGear;
                break;
            case Gears.secondGear:
                i_currentGear++;
                secondGearSpeed = rollDice() * secondGearMultiplier;
                totalSpeed += secondGearSpeed;
                currentGear = Gears.thirdGear;
                break;
            case Gears.thirdGear:
                i_currentGear++;
                thirdGearSpeed = rollDice() * thirdGearMultiplier;
                totalSpeed += thirdGearSpeed;
                currentGear = Gears.fourthGear;
                break;
            case Gears.fourthGear:
                i_currentGear++;
                fourthGearSpeed = rollDice() * fourthGearMultiplier;
                totalSpeed += fourthGearSpeed;
                currentGear = Gears.fifthGear;
                break;
            case Gears.fifthGear:
                i_currentGear++;
                fifthGearSpeed = rollDice() * fifthGearMultiplier;
                totalSpeed += fifthGearSpeed;
                currentGear = Gears.sixthGear;
                break;
            case Gears.sixthGear:
                i_currentGear++;
                sixthGearSpeed = rollDice() * sixthGearMultiplier;
                totalSpeed += sixthGearSpeed;
                break;
            default:
                break;
        }
    }

    public void StartOver() 
    {
        totalSpeed = 0;
        firstGearSpeed = 0;
        secondGearSpeed = 0;
        thirdGearSpeed = 0;
        fourthGearSpeed = 0;
        fifthGearSpeed = 0;
        sixthGearSpeed = 0;

        currentGear = Gears.firstGear;
        i_currentGear = 1;
    }
}
