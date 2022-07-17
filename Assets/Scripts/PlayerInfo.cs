using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo instance = null;

    public int totalRaces = 0;
    public int timesWon = 0;
    public int timesLost = 0;
    public int timesDraw = 0;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
        else if (instance != this) 
        {
            Destroy(gameObject);
        }
    }
}
