using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

 
    private float horMove;
    private bool jump = false;
    void Update()
    {
       
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            horMove = Input.GetAxisRaw("Horizontal");

        }
        else
        {
            horMove = Input.GetAxisRaw("Horizontal") * 0.5f;
           
            
        }
       


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horMove,false,jump);
        jump = false;
    }
}
