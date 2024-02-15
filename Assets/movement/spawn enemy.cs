using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject enemyPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2.0f;  // Adjust this value for spawn frequency
    private float spawnTimer = 0.0f;
    private bool canSpawn = false;
    void Start()
    {
        Invoke("Enable spawn", 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn)
        {
            spawnTimer += Time.deltaTime;
            if(spawnTimer > spawnInterval)
            {
                SpawnEnemy();
                spawnTimer = 0.0f;
             }
        }
    }
    void EnableSpawn()
    {
        canSpawn = true;
    }
void SpawnEnemy(){

}
    
}
