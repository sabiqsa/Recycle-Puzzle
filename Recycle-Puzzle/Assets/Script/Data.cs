using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{

    // Use this for initialization
    private static int score = 0;
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
}
   
