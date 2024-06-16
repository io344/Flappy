using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    FinalScore finalScore;
    public Text txtScore;
    int score;
    string title_score;

    void Start()
    {
        finalScore = FindObjectOfType<FinalScore>();
        score = finalScore.totalScore;
        seeBest();
        LoadHS();
        saveHS();
    }

    void saveHS()
    {
        if(score > LoadHS())
        {
            PlayerPrefs.SetInt(title_score, score);
            PlayerPrefs.Save();
            txtScore.text = "NEW BEST: " + score + " !!!";
        }
    }

    public int LoadHS()
    {
        return PlayerPrefs.GetInt(title_score, 0);
    }

    void seeBest()
    {
        int Best = LoadHS();
        if(Best != 0)
        {
            string best = Best.ToString();
            txtScore.text = "BEST: " + best;
        }
    }
}
