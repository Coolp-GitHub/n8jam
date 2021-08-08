using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    private float _horizontalMovement;
    private bool _jump;

    
    
    void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButton("Jump"))
        {
            _jump = true;
        }

      
    }

    private void FixedUpdate()
    {
         controller.Move(_horizontalMovement,false, _jump);
         _jump = false;

        
    }
}
