using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DamageP : MonoBehaviour
{
    [SerializeField]
    public int HitPointPlayer = 10;
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

            Die();
        }
    }

    public void PlayDeathAnimation()
    {
        animator.SetTrigger("Death_player");
    }

    void Die()
    {

        if (PlayerAlive)
        {
            PlayerAlive = false;
            onDeathEvent.Invoke();
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }
}
