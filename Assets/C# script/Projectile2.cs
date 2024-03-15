using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile2 : MonoBehaviour
{

    public float speed = 3.0f;
    public float range = 10;


    void Update()
    {
        float distance = speed * Time.deltaTime;
        transform.Translate(-transform.right * distance);

        range -= distance;
        if (range <= 0)
        {
            Destroy(gameObject);
        }
    }
}
