using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMove : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float speed;
    public float range = 15.0f;
    private float respawnDelay = 0.0f;
    private Vector3 initialPosition;
    private int HitPoint = 2;
    void Awake()
    {

        initialPosition = transform.position;
        Player = GameObject.FindAnyObjectByType<MovementNew>().transform;
  
        Player = GameObject.Find("Player").transform;
    }
    
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
    public void TakeDamage(int attackValuePlayer)
    {
        HitPoint -= attackValuePlayer;
        if (HitPoint <= 0 ){
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
       DamageP jerry = other.GetComponent<DamageP>();
          if (!jerry)
        {
            return;
        }
        jerry.TakeDamagePlayer(1);
        Destroy(gameObject);
    }
    
}
