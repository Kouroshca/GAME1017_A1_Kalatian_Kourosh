using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 11.0f;
    public float range = 15.0f;
    public int attackValue = 1;
    
    private object other;

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
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(attackValue);
            }
        }
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damagable target = collision.GetComponent<Damagable>();
        if (!target)
        {
            return;
        }
        target.TakeDamage(attackValue);
        Destroy(gameObject);


    }

}

