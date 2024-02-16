using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    // Start is called before the first frame update
 public GameObject enemyPrefab;
void Start()
    {
       if(enemyPrefab != null){ 
        SpawnEnemy();
       }
    }

    void SpawnEnemy()
    {
        // Set the spawn position to the specified point (5, -4, 0)
   
      Vector3 spawnPosition = new Vector3(5.0f,-3.0f,0.0f);
      Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    
    }
}