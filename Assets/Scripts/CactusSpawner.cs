using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
 public float respanwDelay = 70.0f;
 public float maxX = 6.43f;
 public float maxY = -2.48f;
 public float minX = 6.43f;
 public float minY = -2.48f;

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
