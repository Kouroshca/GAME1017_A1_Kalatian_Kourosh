using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Player;
    [SerializeField] float speed;
    public float range = 15.0f;
    void Awake()
    {
        
         Player = GameObject.FindAnyObjectByType<MovementNew>().transform;

        // Find by name
       Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < 20.0f)
        {
            
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }else{
            Destroy(gameObject);
        }
    }
}
