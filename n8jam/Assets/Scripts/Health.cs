using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;

    public bool _isDead = false;
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    void Start()
    {
        currentHealth = maxHealth;
        slider.maxValue = maxHealth;
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

        
        setHealth(currentHealth);
            
        fill.color = gradient.Evaluate(slider.normalizedValue);
        
        
        
    }

    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;
    }
    
    void setHealth(float hp)
    {
        slider.value = hp;
    }
}
