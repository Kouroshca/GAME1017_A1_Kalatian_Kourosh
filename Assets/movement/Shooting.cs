using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public GameObject projectile;
    public Transform blasterposition;
    public float firrate = 5;
    private float timebetweenshots = 1.0f/5.0f; 
    private float shottimer = 0.0f; // when we can shoot again
    
    void Start()
    {
        timebetweenshots = 1.0f/firrate;
    }

    // Update is called once per frame
    void Update()
    {
        shottimer -= Time.deltaTime;
        if(shottimer<0.0f){
            shottimer = 0.0f;
        }
        if(Input.GetKey(KeyCode.Space)){
            if(shottimer<=0.0f){

            
            shoot();
            }
        }
        
    }
    
    public void shoot(){
        GameObject projectileSpawn=Instantiate(projectile,blasterposition.position,blasterposition.rotation);
        shottimer = timebetweenshots;
        throw new NotImplementedException();
    }
   
}
