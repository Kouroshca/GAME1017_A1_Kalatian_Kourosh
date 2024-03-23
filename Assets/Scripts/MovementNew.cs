using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using JetBrains.Annotations;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class MovementNew : MonoBehaviour
{
    public bool UpPressed = false;
    public bool DownPressed = false;
    public bool LeftPressed = false;
    public bool RightPressed = false;
    public float speed = 5.0f;
    public Vector2 InputVector;
    private Animator animator;
    public void Start()
    {
        animator = GetComponent<Animator>();

    }



    void Update()
    {
        UpPressed = Input.GetKey(KeyCode.W);
        DownPressed = Input.GetKey(KeyCode.S);
        LeftPressed = Input.GetKey(KeyCode.A);
        RightPressed = Input.GetKey(KeyCode.D);
        InputVector = Vector2.zero;

        if (UpPressed)
        {
            InputVector += Vector2.up;
        }
        if (DownPressed)
        {
            InputVector += Vector2.down;
        }
        if (LeftPressed)
        {
            InputVector += Vector2.left;
        }
        if (RightPressed)
        {
            InputVector += Vector2.right;
        }



        InputVector.Normalize();

        animator.SetFloat("x.Input", InputVector.x);
        animator.SetFloat("y.Input", InputVector.y);
        transform.Translate(InputVector * speed * Time.deltaTime);

    }

}