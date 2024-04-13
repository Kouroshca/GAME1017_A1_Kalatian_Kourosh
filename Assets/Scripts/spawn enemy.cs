using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using Random = System.Random;

public class spawnenemy : MonoBehaviour
{
   
 public GameObject enemyPrefab;
 public float respanwDelay = 70.0f;
 public float maxX = 7.0f;
 public float maxY = -3.0f;
 public float minX = 1.0f;
 public float minY = -5.0f; 
void Start()
    {
       StartCoroutine(EnemySpawnRoutine());
       if(enemyPrefab != null){ 
        SpawnEnemy();
       }
    }
    IEnumerator EnemySpawnRoutine()
    {
      while(true)
      {
        yield return new WaitForSecondsRealtime(respanwDelay);
        SpawnEnemy();
      }
    }

    void SpawnEnemy()
    {
      float randomX = UnityEngine.Random.Range(minX,maxX);
      float randomY = UnityEngine.Random.Range(minY,maxY);
      Vector3 spawnPosition = new Vector3(randomX,randomY,0.0f);
      Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}