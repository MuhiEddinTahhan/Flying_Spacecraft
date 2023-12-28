using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreTXT;
    void Start() 
    {
        scoreTXT = GetComponent<TMP_Text>();
        scoreTXT.text = "START";
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreTXT.text = score.ToString();
    }
}
