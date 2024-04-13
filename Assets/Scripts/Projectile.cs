using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 11.0f;
    public float range = 15.0f;
    private int attackValuePlayer = 1;


    void Update()
    {
        float distance = Speed * Time.deltaTime;
        transform.Translate(-transform.right * distance);
        Vector3 velocity = new Vector3(0, -distance, 0);
        range -= distance;


        if (range < 0.0f)
        {
            Destroy(gameObject);
        }
    }
    // needs colider and rigidbody attached to the game object.
    void OnTriggerEnter2D(Collider2D other)
    {
        Damage target = other.GetComponent<Damage>();
        if (!target)
        {
            return;
        }
        target.TakeDamage(attackValuePlayer);
        Destroy(gameObject);
    }
}

