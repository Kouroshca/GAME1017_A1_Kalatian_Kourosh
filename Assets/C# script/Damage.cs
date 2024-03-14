using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int Hitpoint = 2;
    public void TakeDamage(int attackValue)
    {
        Hitpoint -= attackValue;
        if (Hitpoint <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
