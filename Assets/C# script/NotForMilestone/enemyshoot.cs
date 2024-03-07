using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectileprefab;
    public Transform blasterposition;
    public float shootinterval = 3.0f;
    
    public float firrate = 0.5f;
   public float shoottimer = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       shoottimer += Time.deltaTime;
       if(shoottimer >=1.0f)
       {
        Shoot();
        shoottimer = 0.0f;
       }
    }
    public void Shoot(){

     //Quaternion rotation = Quaternion.Euler(0.0f,0f,90f);
     //Quaternion Rotation = blasterposition.rotation;
    //Instantiate(projectileprefab,blasterposition.position, rotation);
    Quaternion rotation = blasterposition.rotation;
    GameObject projectileSpawn = Instantiate(projectileprefab,blasterposition.position,rotation);
    Rigidbody2D projectileRb = projectileSpawn.GetComponent<Rigidbody2D>();
    projectileRb.velocity =  new Vector3(-10.0f,0.0f);
    }
}
