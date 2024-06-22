    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
      public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public static int scoreValue;
    private static int highScore;

    void Start()
    {
        // Load the high score from PlayerPrefs
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        
        // Display the initial high score
        UpdateHighScoreText();
        
        // Display the initial score
    
        ResetScoreText();
    }

    void Update()
    {
        // Update the score display
        UpdateScoreText();

        // Check and update the high score if needed
        if (scoreValue > highScore)
        {
            highScore = scoreValue;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            UpdateHighScoreText();
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + scoreValue;
            
        }
        else
        {
            Debug.LogError("scoreText is not assigned in the Inspector");
        }
        
    } 

    void UpdateHighScoreText()
    {
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore;
        }
        else
        {
            Debug.LogError("highScoreText is not assigned in the Inspector");
        }
    }
    void ResetScoreText()
    {
     scoreValue =0 ;
     UpdateScoreText();
    }
}
