using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;

    public bool _isDead = false;
    void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            if (gameObject.name == "Player")
            {
                _isDead = true;
            }
            else
            {
                Destroy(this.gameObject);
            }
            
        }
    }

    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
    }
    
}
