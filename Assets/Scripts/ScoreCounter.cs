using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text textScore;
    Death playerStatus;
    void Start()
    {
        playerStatus = FindObjectOfType<Death>(); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        {
            score ++;
        }
    }
    private void Update()
    {
        textScore.text = score.ToString();
    }
}
