using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleDamage : MonoBehaviour
{
    private float hitpoint =1;
    [SerializeField]
    AudioSource Hit;
   
     public void TakeDamage(int attackValuePlayer)
    {
        hitpoint -= attackValuePlayer;
        if (hitpoint <= 0)
        {
            Die();

        }
    }
    void Die()
    {
        Destroy(gameObject,0.5f);
        Hit.Play();
    }
}
