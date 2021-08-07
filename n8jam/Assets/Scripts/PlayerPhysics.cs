using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private GameObject groundCheck;
    [SerializeField] private Rigidbody2D rb;
    private bool _isGrounded;
    
    
 

    private void Update()
    {
        RaycastHit2D groundCheckRay = Physics2D.Raycast(groundCheck.transform.position, transform.up * -1, 0.2f);
        
        _isGrounded = groundCheckRay.collider != null && groundCheckRay.collider.gameObject.CompareTag("Ground");


        if (_isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }


        if (Input.GetKey(KeyCode.D) && rb.velocity.x < maxSpeed)
        {
            rb.AddForce(transform.right * speed);
            
        }
        if (Input.GetKey(KeyCode.A) && rb.velocity.x > maxSpeed * -1)
        {
            rb.AddForce(transform.right * -speed);
        }
        if(!Input.GetKeyDown(KeyCode.A) && !Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
      Gizmos.DrawRay(groundCheck.transform.position, transform.up * -0.2f);
     
    }
}
