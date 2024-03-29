using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Helath : MonoBehaviour
{
    
    public  static int health = 10;
    TextMeshProUGUI Lives;
    void Start()
    {
        Lives = GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
      Lives.text = "Lives: " + health;
    }
}
