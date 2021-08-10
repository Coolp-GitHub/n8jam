using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    public GameObject bulletPrefab;
    
    [SerializeField] private float cooldown;
    private bool _canShoot = true;

  

  

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && _canShoot)
        {
            Shoot();
            _canShoot = false;
            StartCoroutine(Cooldown());
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
        _canShoot = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.CompareTag("PowerUp"))
        {
            switch ()
            {
                
            }
        }
    }
}
