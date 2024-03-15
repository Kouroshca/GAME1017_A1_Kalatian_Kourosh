using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform Player;
    [SerializeField] float speed;
    public float range = 15.0f;
    private float respawnDelay = 0.0f;
    private Vector3 initialPosition;
    void Awake()
    {

        initialPosition = transform.position;
        Player = GameObject.FindAnyObjectByType<MovementNew>().transform;
        // Find by name
        Player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < range)
        {

            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
            StartCoroutine(RespawnEnemy());
        }
    }
    IEnumerator RespawnEnemy()
    {
        yield return new WaitForSeconds(respawnDelay);
        GameObject newEnemy = Instantiate(gameObject, initialPosition, Quaternion.identity);
        Destroy(newEnemy.GetComponent<enemymovement>());
    }
}
