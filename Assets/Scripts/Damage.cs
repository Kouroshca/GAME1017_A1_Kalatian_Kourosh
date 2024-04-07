using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;


public class Damage : MonoBehaviour
{

    [SerializeField]

    private int HitpointEnemy = 2;
    public Animator animator;
    public UnityEvent<int> OnDieEvent;
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

    /*internal void TakeDamagePlayer(int attackValue)
    {
        throw new NotImplementedException();
    }*/

    void Die()
    {
        
        ScoreScript.scoreValue += 10;
        if (gameObject != null)
        {
            animator.SetTrigger("Died");
            Destroy(gameObject, 0.5f);
        }
    }
}
