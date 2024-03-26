using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageP : MonoBehaviour
{
    [SerializeField]
    private int HitPointPlayer = 4;
    public void TakeDamagePlayer(int AttackValueEnemy)
    {
        HitPointPlayer -= AttackValueEnemy;
        if (HitPointPlayer <= 0)
        {
            DiePlayer();
        }
    }
    void DiePlayer()
    {
        Destroy(gameObject);
    }
    public bool Alive
    {
        get{ return HitPointPlayer>0;}
    }

}
