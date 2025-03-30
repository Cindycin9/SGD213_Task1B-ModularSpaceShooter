using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    // Variables for Score system and Score Text
    public static int score = 0;
    public int maxScore;
    public TextMeshProUGUI scoreTxt;

    public GameObject Score;
    public GameObject YouWinText;



    // Score increases to a new score
    public void AddScore(int newScore)
    {
        score += newScore;
    }



    // Score is 0 when the game has started
    void Start()
    {
        score = 0;
    }

  
    // Score text increases 
    public void UpdateScore()
    {
        scoreTxt.text = "Score:" + score;
    }

    // If the max score is completed, You win text and Game over screen will activate
    void Update()
    {
        UpdateScore();

        if (score >= 5)
        {
            Score.SetActive(false);
            YouWinText.SetActive(true);
            GameManagerScript.isGameOver = true;
            Debug.Log("END SCREEN");
        }
    }
   
}
