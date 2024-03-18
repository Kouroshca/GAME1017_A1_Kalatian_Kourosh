using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    [SerializeField]
    private int HitPoint =2; 
    public void TakeDamage(int attackValue)
     {
        HitPoint -= attackValue;
        if (HitPoint <= 0)
        {
            Demolish();
        }  
     }
    void Demolish()
     {
        Destroy(gameObject);
     }

}
