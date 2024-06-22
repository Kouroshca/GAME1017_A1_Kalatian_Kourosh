using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Damage : MonoBehaviour
{
    [SerializeField]
    private int HitpointEnemy = 2;
    public Animator animator;
    public UnityEvent<int> OnDieEvent;
    [SerializeField]
    private AudioSource Explosion;
    private DamageP damageP;

    [SerializeField]
    private GameObject heartPrefab;

    void Start()
    {
        animator = GetComponent<Animator>();
        if (OnDieEvent == null)
        {
            OnDieEvent = new UnityEvent<int>();
        }
        if (Explosion == null)
        {
            Explosion = GetComponent<AudioSource>();
        }
    }

    public void TakeDamage(int attackValuePlayer)
    {
        HitpointEnemy -= attackValuePlayer;
        if (HitpointEnemy <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (ScoreScript.scoreValue != null)
        {
            OnDieEvent.Invoke(ScoreScript.scoreValue += 10);
        }

        if (gameObject != null)
        {
            if (animator != null)
            {
                animator.SetTrigger("Died");
            }

            if (Explosion != null)
            {
                Explosion.Play();
            }


            if (heartPrefab != null)
            {
                if (true)
                {
                    Instantiate(heartPrefab, transform.position, Quaternion.identity);
                }
            }

            Destroy(gameObject, 0.5f);
        }
    }
}
