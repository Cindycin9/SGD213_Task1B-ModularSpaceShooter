using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{ 
    public int score = 0;
    public int maxScore;
    //    public Text ScoreText;
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
        //        ScoreText.text = "Score 0" + score;
        //        TextMeshProUGUI.text = "Score 0" + score.ToString();
        scoreTxt.text = "Score:" + score;
 
    }

 
  void Update()
    {
        UpdateScore();

        if(score ==maxScore)
        {
            Score.SetActive(false);
            YouText.SetActive(true);
        }
        if (score >=6)
        {
            GameManagerScript.isGameOver = true;
        }
    }
   
}
