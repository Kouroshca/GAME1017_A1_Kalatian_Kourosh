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
    // Start is called before the first frame update
 public GameObject enemyPrefab;
 public float respanwDelay = 70.0f;
 public float maxX = 7.0f;
 public float maxY = 2.0f;
 public float minX = 0.0f;
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
        yield return new WaitForSeconds(respanwDelay);
        SpawnEnemy();
      }
    }

    void SpawnEnemy()
    {
      float randomX = UnityEngine.Random.Range(minX,maxX);
      float randomY = UnityEngine.Random.Range(minY,maxY);
      //Vector3 spawnPosition = new Vector3(6.0f,-3.0f,0.0f);
      Vector3 spawnPosition = new Vector3(randomX,randomY,0.0f);
      Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
      
    }
}