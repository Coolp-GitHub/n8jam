using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float dmg;
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private ParticleSystem explosion;

    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.GetComponent<Health>() != null)
        {
            Health hp = other.gameObject.GetComponent<Health>();
            hp.TakeDamage(dmg);
        }

        ParticleSystem explode = Instantiate(explosion, transform.position, quaternion.identity);
        explode.transform.parent = null;
        Destroy(gameObject);

    }

   
    
    
}
