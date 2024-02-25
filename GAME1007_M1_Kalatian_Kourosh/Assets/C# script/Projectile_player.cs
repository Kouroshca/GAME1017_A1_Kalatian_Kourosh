using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
public float Speed = 11.0f;
public float range = 100.0f;
void Update()
    {
        float distance = Speed * Time.deltaTime;
        transform.Translate(-transform.right * distance);
        Vector3 velocity = new Vector3(0,- distance, 0);
        //transform.Translate (velocity, Space.Self);
        range -= distance;
        if(range<0.0f)
        {
            Destroy(gameObject);
        }
    }
}

