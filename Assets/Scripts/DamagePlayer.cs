using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DamageP : MonoBehaviour
{
    [SerializeField]
    private int HitPointPlayer = 10;
    public Animator animator;
    bool PlayerAlive = true;

    public UnityEvent onDeathEvent;

    [SerializeField]
    AudioSource hitsound;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void TakeDamagePlayer(int AttackValueEnemy)
    {
        if (hitsound != null)
        {
            hitsound.Play();
        }
        HitPointPlayer -= AttackValueEnemy;
        Helath.health = HitPointPlayer;
        if (HitPointPlayer <= 0)
        {
            //PlayDeathAnimation();
            Die();
        }
    }

    public void PlayDeathAnimation()
    {
       animator.SetTrigger("Death_player");
    }

    void Die()
    {
        //gameObject.SetActive(false);
        if (PlayerAlive)
        {
            PlayerAlive = false;
            onDeathEvent.Invoke();
        }
    }

}
