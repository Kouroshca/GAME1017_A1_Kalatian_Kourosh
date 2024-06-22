using UnityEngine;

public class Heart : MonoBehaviour
{
    public int healthAmount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DamageP damageP = other.GetComponent<DamageP>();
            if (damageP != null)
            {
                damageP.HitPointPlayer += healthAmount;
                Debug.Log("hello");
               Helath.health++;
                Destroy(gameObject);
            }
        }
    }
}
