using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectile;
    public Transform blasterposition;
    public float firrate = 5;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.LeftShift)){
            Shoot();
        }
    }
    public void Shoot(){
        GameObject projectileSpawn = Instantiate(projectile, blasterposition);
    

    }
}
