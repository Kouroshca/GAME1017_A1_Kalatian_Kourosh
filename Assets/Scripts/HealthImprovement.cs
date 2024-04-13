using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthImprovement : MonoBehaviour
{
   private int HitPoint = 1;
   public GameObject player;
    
      public void TakeDamage(int attackValuePlayer)
    {
        HitPoint -= attackValuePlayer;
       
        if (HitPoint <= 0 ){
            Destroy(gameObject);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       DamageP jerry = other.GetComponent<DamageP>();
          if (!jerry)
        {
            return;
        }
        jerry.TakeDamagePlayer(1);
        
    }
}

