using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Damage : MonoBehaviour
{
  
    [SerializeField]
    
    private int HitpointEnemy = 2;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void TakeDamage(int attackValuePlayer)
    {
        HitpointEnemy -= attackValuePlayer;
        if (HitpointEnemy <= 0)
        {
            Die();
            
        }
    }

    internal void TakeDamagePlayer(int attackValue)
    {
        throw new NotImplementedException();
    }

    void Die()
    {
        
        if (gameObject != null)
        {
          animator.SetTrigger("Died");
        }else
        {
            Destroy(gameObject);
        }
        
    }
}
