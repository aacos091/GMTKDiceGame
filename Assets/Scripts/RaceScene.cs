using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaceScene : MonoBehaviour
{
    public TMP_Text gearDisplay;
    public TMP_Text playerSpeedLabel;
    public TMP_Text opponentSpeedLabel;
    public BasicCarClass playerCar;
    public BasicCarClass opponentCar;
    public TMP_Text gearInfoDisplay;
    public Drag dragScene;

    // Start is called before the first frame update
    void Start()
    {
        gearDisplay.text = "Neutral";
        playerSpeedLabel.text = "0 mph";
        opponentSpeedLabel.text = "0 mph";
        gearInfoDisplay.text = "Ready to Roll";

    }

    // Update is called once per frame
    void Update()
    {
        switch (playerCar.currentGear) 
        {
            case 0:
                gearDisplay.text = "Neutral";
                gearInfoDisplay.text = "Ready to Roll";
                break;
            case 1:
                gearDisplay.text = "1st Gear";
                gearInfoDisplay.text = "Rolled a " + playerCar.firstRoll + " X " + playerCar.firstGearMultiplier + "<br>" + playerCar.firstGearSpeed + " has been added to your speedometer";
                break;
            case 2:
                gearDisplay.text = "2nd Gear";
                gearInfoDisplay.text = "Rolled a " + playerCar.secondRoll + " X " + playerCar.secondGearMultiplier + "<br>" + playerCar.secondGearSpeed + " has been added to your speedometer"; ;
                break;
            case 3:
                gearDisplay.text = "3rd Gear";
                gearInfoDisplay.text = "Rolled a " + playerCar.thirdRoll + " X " + playerCar.thirdGearMultiplier + "<br>" + playerCar.thirdGearSpeed + " has been added to your speedometer"; ;
                break;
            case 4:
                gearDisplay.text = "4th Gear";
                gearInfoDisplay.text = "Rolled a " + playerCar.fourthRoll + " X " + playerCar.fourthGearMultiplier + "<br>" + playerCar.fourthGearSpeed + " has been added to your speedometer"; ;
                break;
            case 5:
                gearDisplay.text = "5th Gear";
                gearInfoDisplay.text = "Rolled a " + playerCar.fifthRoll + " X " + playerCar.fifthGearMultiplier + "<br>" + playerCar.fifthGearSpeed + " has been added to your speedometer"; ;
                break;
            case 6:
                gearDisplay.text = "6th Gear";
                gearInfoDisplay.text = "Rolled a " + playerCar.sixthRoll + " X " + playerCar.sixthGearMultiplier + "<br>" + playerCar.sixthGearSpeed + " has been added to your speedometer"; ;
                break;
        }

        if (dragScene.raceIsFinished) 
        {
            if (playerCar.totalSpeed > opponentCar.totalSpeed)
            {
                gearInfoDisplay.text = "You Won!";
                gearDisplay.text = "Neutral";
            }
            else if (playerCar.totalSpeed < opponentCar.totalSpeed)
            {
                gearInfoDisplay.text = "You Lost!";
                gearDisplay.text = "Neutral";
            }
            else if (playerCar.totalSpeed == opponentCar.totalSpeed)
            {
                gearInfoDisplay.text = "It's a draw.";
                gearDisplay.text = "Neutral";
            }
        }

        playerSpeedLabel.text = playerCar.totalSpeed + " mph";
        opponentSpeedLabel.text = opponentCar.totalSpeed + " mph";
    }
}
