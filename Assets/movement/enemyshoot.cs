using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectileprefab;
    public Transform blasterposition;
    public float shootinterval = 3.0f;
    
    public float firrate = 1.333f;
   public float shoottimer = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       shoottimer += Time.deltaTime;
       if(shoottimer >=1.0f/firrate)
       {
        Shoot();
        shoottimer = 0.0f;
       }
    }
    public void Shoot(){
//GameObject projectileSpawn = Instantiate(projectile, blasterposition);
     Quaternion rotation = blasterposition.rotation;
     //GameObject projectileSpawn = Instantiate(projectileprefab, blasterposition);
     //Rigidbody2D projectileRb = projectileSpawn.GetComponent<Rigidbody2D>();
    Quaternion Rotation = blasterposition.rotation;
    Instantiate(projectileprefab,blasterposition.position, rotation);
     
     //Instantiate(projectileprefab,blasterposition.position,rotation);

    }
}
