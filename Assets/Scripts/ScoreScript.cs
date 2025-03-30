using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int score = 0;
    public int maxScore;
    public TextMeshProUGUI scoreTxt;

    public GameObject Score;
    public GameObject YouText;


    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }

    public void UpdateScore()
    {
        scoreTxt.text = "Score:" + score;
    }


    void Update()
    {
        UpdateScore();

        if (score >= 2)
        {
            Score.SetActive(false);
            YouText.SetActive(true);
            GameManagerScript.isGameOver = true;
            Debug.Log("END SCREEN");
        }
    }
   
}
