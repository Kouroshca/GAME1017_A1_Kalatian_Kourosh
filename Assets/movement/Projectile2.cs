using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{
    // Start is called before the first frame update
      public float speed = 7.0f; // meter per second
      
       // Update is called once per frame
    void Update()
    {
        float distance = speed * Time.deltaTime;
        transform.Translate(-transform.right * distance);
    }
}
