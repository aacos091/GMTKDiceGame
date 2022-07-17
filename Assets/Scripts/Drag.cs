using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    C_BasicRaceCar playerCar;
    C_BasicRaceCar opponentCar;

    private void Start()
    {
        playerCar = new C_BasicRaceCar("Player");
        opponentCar = new C_BasicRaceCar("Opponent");

        StartRace();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerCar.i_currentGear <= 6) 
        {
            playerCar.ShiftRoll();
            opponentCar.ShiftRoll();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && playerCar.i_currentGear > 6) 
        {
            StartRace();
        }
    }

    void StartRace() 
    {
        Debug.Log("Welcome to Roll Drag Testing!");
        Debug.Log("Press Space to begin the race!");
        playerCar.StartOver();
        opponentCar.StartOver();
    }
}
