using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] Transform Player;
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position)< 5.0f)
        {
           transform.position = Vector3.MoveTowards(
            transform.position,
            Player.position,
            2.0f * Time.deltaTime
           );
        }
    }
}
