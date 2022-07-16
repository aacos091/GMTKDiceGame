using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    int d3_Result;
    int d6_Result;
    int d10_Result;
    int d20_Result;
    int finalResult;

    int opp_d3_Result;
    int opp_d6_Result;
    int opp_d10_Result;
    int opp_d20_Result;
    int opp_finalResult;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            RollDice();
        }
    }
    
    void RollDice() // A simple dice roll with d3, d6, d10 and d20. Shows ind. results ans the grand total
    {
        d3_Result = Random.Range(1, 4);
        d6_Result = Random.Range(1, 7);
        d10_Result = Random.Range(1, 11);
        d20_Result = Random.Range(1, 21);

        Debug.Log("Result of d3: " + d3_Result);
        Debug.Log("Result of d6: " + d6_Result);
        Debug.Log("Result of d10: " + d10_Result);
        Debug.Log("Result of d20: " + d20_Result);

        opp_d3_Result = Random.Range(1, 4);
        opp_d6_Result = Random.Range(1, 7);
        opp_d10_Result = Random.Range(1, 11);
        opp_d20_Result = Random.Range(1, 21);

        Debug.Log("Opponent Result of d3: " + opp_d3_Result);
        Debug.Log("Opponent Result of d6: " + opp_d6_Result);
        Debug.Log("Opponent Result of d10: " + opp_d10_Result);
        Debug.Log("Opponent Result of d20: " + opp_d20_Result);

        finalResult = d3_Result + d6_Result + d10_Result + d20_Result;

        opp_finalResult = opp_d3_Result + opp_d6_Result + opp_d10_Result + opp_d20_Result;

        Debug.Log("Grand Total: " + finalResult);
        Debug.Log("Opponent Total: " + opp_finalResult);

        if (finalResult > opp_finalResult) 
        {
            Debug.Log("You win!");
        }
        else if (finalResult < opp_finalResult) 
        {
            Debug.Log("You lose!");
        }
        else 
        {
            Debug.Log("It's a draw!");
        }
    }
}
