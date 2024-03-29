using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    
    public GameObject projectileprefab;
    public Transform blasterposition;
    public float shootinterval = 3.0f;

    public float firrate = 0.3f;
    public float shoottimer = 1.0f;
    void Update()
    {

        shoottimer += Time.deltaTime;
        if (shoottimer >= 1.0f)
        {
            Shoot();
            shoottimer = 0.0f;
        }
    }
    public void Shoot()
    {
        Quaternion rotation = blasterposition.rotation;
        GameObject projectileSpawn = Instantiate(projectileprefab, blasterposition.position, rotation);
        Rigidbody2D projectileRb = projectileSpawn.GetComponent<Rigidbody2D>();
        projectileRb.velocity = new Vector3(-10.0f, 0.0f);
    }
}
