using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //to acces other scripts
    public static GameManager instance;
    
    [SerializeField]  TextMeshProUGUI scoreText;
    [SerializeField]  TextMeshProUGUI highscoreText;
  //  public Text scoreText;
   // public Text highscoreText;

   //create  a new instance 
   private Scores scoreData = new Scores();
   
   
    // int score = 0;
    //int highscore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
      scoreData = SaveData.Load();
      AddScore(0);
    }

    public void AddScore(int points = 1)
    {
      //change by 1
      scoreData.score += points;
      

      //highscore
      if (scoreData.score > scoreData.highScore)
      {
          scoreData.highScore = scoreData.score;
      }
      
      //update the text 
      scoreText.text = scoreData.score.ToString();
      highscoreText.text = scoreData.highScore.ToString();
    }

    private void Awake()
    {
        //here we show that as the game loads this is the instacne of this manager
        instance = this;
    }

    private void OnDestroy()
    {
        SaveData.Save(scoreData);
    }
}
