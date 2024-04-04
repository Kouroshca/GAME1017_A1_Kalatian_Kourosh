using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageP : MonoBehaviour
{
    [SerializeField]
    private int HitPointPlayer = 10;
    public Animator animator;
    bool PlayerAlive = true; 
    
    [SerializeField]
    AudioSource hitsound;
    void Start()
    {
         animator = GetComponent<Animator>();
    }
    public void TakeDamagePlayer(int AttackValueEnemy)
    {
        if (hitsound != null){
        hitsound.Play();
      
        }
        HitPointPlayer -= AttackValueEnemy;
        Helath.health = HitPointPlayer;
        if (HitPointPlayer <= 0)
        {
           DiePlayer();
            
        }
    }
    void DiePlayer()
    {
       if (PlayerAlive)
       {
        animator.SetTrigger("Death_player");
        PlayerAlive = false;
       
       } else if (! PlayerAlive )
       {
        
       }
       
    }
    
}
