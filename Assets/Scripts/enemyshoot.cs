using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    
    public GameObject projectileprefab;
    public Transform blasterposition;
    private float shootinterval = 2.0f;

    //private float firrate = 0.2f;
    private float shoottimer = 1.0f;
    void Update()
    {

        shoottimer += Time.deltaTime;
        if (shoottimer >= shootinterval)
        {
            Shoot();
            shoottimer = 0.0f;
        }
    }
    public void Shoot()
    {
        if (projectileprefab && blasterposition) // Check if the prefab and position are set
        {
            // Instantiate the projectile at the blaster position and orientation
            GameObject projectile = Instantiate(projectileprefab, blasterposition.position, blasterposition.rotation);
            Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();

            if (projectileRb) // Check if the projectile has a Rigidbody2D component
            {
                // Set the velocity of the projectile
                projectileRb.velocity = new Vector2(-10.0f, 0.0f); // Assuming leftward shot, use Vector2 for Rigidbody2D
            }
        }
    }

    
}

   /* public void Shoot()
    {
        Quaternion rotation = blasterposition.rotation;
        GameObject projectileSpawn = Instantiate(projectileprefab, blasterposition.position, rotation);
        Rigidbody2D projectileRb = projectileSpawn.GetComponent<Rigidbody2D>();
        projectileRb.velocity = new Vector3(-10.0f, 0.0f);
    }*/