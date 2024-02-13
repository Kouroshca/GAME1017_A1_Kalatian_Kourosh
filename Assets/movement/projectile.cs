using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projectile : MonoBehaviour
{
public float Speed = 7.0f;

    
    void Update()
    {
        
     float distance = Speed * Time.deltaTime;      
   transform.Translate(-transform.right * distance);
    }
}
    

   

