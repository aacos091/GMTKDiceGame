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

    // Start is called before the first frame update
    void Start()
    {
        gearDisplay.text = "Neutral";
        playerSpeedLabel.text = "0 mph";
        opponentSpeedLabel.text = "0 mph";

    }

    // Update is called once per frame
    void Update()
    {
        switch (playerCar.currentGear) 
        {
            case 0:
                gearDisplay.text = "Neutral";
                break;
            case 1:
                gearDisplay.text = "1st Gear";
                break;
            case 2:
                gearDisplay.text = "2nd Gear";
                break;
            case 3:
                gearDisplay.text = "3rd Gear";
                break;
            case 4:
                gearDisplay.text = "4th Gear";
                break;
            case 5:
                gearDisplay.text = "5th Gear";
                break;
            case 6:
                gearDisplay.text = "6th Gear";
                break;
        }

        playerSpeedLabel.text = playerCar.totalSpeed + " mph";
        opponentSpeedLabel.text = opponentCar.totalSpeed + " mph";
    }
}
