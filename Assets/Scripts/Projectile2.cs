using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{

    public float speed = 1.0f;
    public float range = 10;
    private int AttackValueEnemy = 1;
    void Update()
    {
        float distance = speed * Time.deltaTime;
        transform.Translate(-transform.right * distance);

        range -= distance;
        if (range <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        DamageP player = other.GetComponent<DamageP>();
        if (!player)
        {
            return;
        }
        player.TakeDamagePlayer(AttackValueEnemy);
        Destroy(gameObject);

    }
}
