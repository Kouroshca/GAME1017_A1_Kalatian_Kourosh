using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipmovement : MonoBehaviour
{
    public bool UpPressed = false;
    public bool DownPressed = false;
    public bool LeftPressed = false;
    public bool RightPressed = false;
    public float speed = 5.0f;

    

    // Update is called once per frame
    void Update()
    {
         UpPressed = Input.GetKey(KeyCode.W);
         DownPressed = Input.GetKey(KeyCode.S);
         LeftPressed = Input.GetKey(KeyCode.A);
         RightPressed = Input.GetKey(KeyCode.D);
        if (UpPressed){
            transform.Translate(Vector3.up *speed  *Time.deltaTime);
            } if ( DownPressed ){
                transform.Translate(Vector3.down * speed * Time.deltaTime);

            }if ( LeftPressed){
                transform.Translate(Vector3.left*speed *Time.deltaTime);
            }
            if ( RightPressed ){
                transform.Translate(Vector3 .right *speed * Time.deltaTime);
            }
    }
}
