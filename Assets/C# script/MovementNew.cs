using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementNew : MonoBehaviour
{
    public bool UpPressed = false;
    public bool DownPressed = false;
    public bool LeftPressed = false;
    public bool RightPressed = false;
    public float speed = 5.0f;
    public Vector2 InputVector;
    
    void Start ()
    {

    }
    

    // Update is called once per frame
   void Update()
    {
       UpPressed = Input.GetKey(KeyCode.W);
       DownPressed = Input.GetKey(KeyCode.S);
       LeftPressed = Input.GetKey(KeyCode.A);
       RightPressed = Input.GetKey(KeyCode.D);
       InputVector = new Vector2(0,0);
       float dt = Time.deltaTime;
       Vector3 direction =  Vector3.zero;
       
       if(DownPressed){
           
            transform.position += new Vector3(0.0f,-1.0f,0.0f) * speed *Time.deltaTime; 
        }
       
         if (UpPressed){
            
            transform.position += new Vector3 (0.0f,1.0f,0.0f)* speed * Time.deltaTime;
        }
       
         if (LeftPressed){
          
            transform.position += new Vector3(-1.0f,0.0f,0.0f) * speed * Time.deltaTime;
        }
        if(RightPressed){
           
            transform.position += new Vector3(1.0f,0.0f,0.0f) * speed * Time.deltaTime;

        }
    InputVector.Normalize();
    transform.Translate(InputVector*speed * Time.deltaTime);


    }
   
}
