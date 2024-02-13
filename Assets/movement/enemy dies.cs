using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health = 3; // Example health value

    public void TakeDamage(int damageAmount)
    {
        Debug.Log($"Enemy took {damageAmount} damage.");
        // Subtract damage from health
        Health -= damageAmount;

        // Check if the enemy has run out of health
        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemy died.");
        // Destroy the enemy GameObject
        Destroy(gameObject);
    }
}
