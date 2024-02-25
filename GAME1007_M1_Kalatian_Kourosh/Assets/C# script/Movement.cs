using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool UpPressed = false;
    public bool DownPressed = false;
    public bool LeftPressed = false;
    public bool RightPressed = false;
    public float speed = 5.0f;
    public Vector2 InputVector;
    

    // Update is called once per frame
   void Update()
    {
       UpPressed = Input.GetKey(KeyCode.W);
       DownPressed = Input.GetKey(KeyCode.S);
       LeftPressed = Input.GetKey(KeyCode.A);
       RightPressed = Input.GetKey(KeyCode.D);
       InputVector = new Vector2(0,0);
       if(DownPressed){
            InputVector.y -= 1;
        }
         if (UpPressed){
            InputVector.y +=1;
        }
         if (LeftPressed){
            InputVector.x -=1;
        }if(RightPressed){
            InputVector.x +=1;
        }
    InputVector.Normalize();
    transform.Translate(InputVector*speed * Time.deltaTime);

    }
   
}
