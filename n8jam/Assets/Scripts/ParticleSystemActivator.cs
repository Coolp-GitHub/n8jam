using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemActivator : MonoBehaviour
{
    private ParticleSystem _explode;
    private float cooldown = .1f;

    private void Update()
    {
        _explode = this.GetComponent<ParticleSystem>();
       
        _explode.Play();

        StartCoroutine(Cooldown());
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(cooldown);
       Destroy(gameObject);
    }
    
}
