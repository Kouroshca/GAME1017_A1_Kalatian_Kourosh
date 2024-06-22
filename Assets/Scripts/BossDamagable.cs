using UnityEngine;

public class BossDamagable : MonoBehaviour
{
    [SerializeField] private int healthEnemy;

    public void TakeDamage(int attackValuePlayer)
    {
        healthEnemy -= attackValuePlayer;
        if (healthEnemy <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        ScoreScript.scoreValue += 20;
        Destroy(gameObject, 0.5f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Assuming the bullets have a tag "Bullet"
        if (collision.CompareTag("Bullet"))
        {
        }
        }
    }

