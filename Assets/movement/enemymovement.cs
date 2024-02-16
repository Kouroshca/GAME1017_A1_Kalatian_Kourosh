using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Player;
    [SerializeField] float speed;

    void Awake()
    {
        // Find and reference the transform of the player when the enemy is spawned.

        // Fınd by the movement compenent
        // Player = GameObject.FindAnyObjectByType<MovementNew>().transform;

        // Find by name
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Player.position) < 8.0f)
        {
            
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
