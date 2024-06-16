using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text totalscrText;
    ScoreCounter scoreCounter;
    public int totalScore;
    void Start()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>();
        totalScore = scoreCounter.score;
        totalscrText.text = "SCORE: " + totalScore.ToString();
    }
}
