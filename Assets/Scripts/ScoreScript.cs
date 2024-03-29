using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI Score;

    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        Score.text = "Score: " + scoreValue;
    }
}
