using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float dmg;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.CompareTag("Enemy"))
        {
            Health hp = other.gameObject.GetComponent<Health>();
            hp.TakeDamage(dmg);
            
            Destroy(gameObject);
            
        }
    }
}
