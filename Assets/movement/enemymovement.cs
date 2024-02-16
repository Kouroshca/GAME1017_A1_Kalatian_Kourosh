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
        if (Vector3.Distance(transform.position, Player.position)< 8.0f)
        {
           transform.Translate(Vector3.left * 1.0f *Time.deltaTime);
           
        }
    }
}
