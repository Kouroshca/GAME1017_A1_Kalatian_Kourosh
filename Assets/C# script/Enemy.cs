using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Enemy : MonoBehaviour
{
    public int maxHelath = 100;
    private int currentHealth;

    void Start()
    {
        InitializationHealth();
    }

    // Update is called once per frame

    void InitializationHealth()
    {
        currentHealth = maxHelath;
    }
    void Update()
    {
        if (IsDefeated())
        {
            Debug.Log("enemy destroyed");
        }
    }
    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.Log("Error: damage cannot be negative.");
            return;
        }
        currentHealth -= damage;
        Debug.Log($"Enemy took {damage} damage. Current health: {currentHealth}");
        if (IsDefeated())
        {
            Debug.Log("Enemy defeated!");
        }

    }
    bool IsDefeated()
    {
        return currentHealth <= 0;
    }

    internal void TakeDamage(float damage)
    {
        throw new NotImplementedException();
    }
}
