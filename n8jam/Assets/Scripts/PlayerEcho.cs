using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerEcho : MonoBehaviour
{
    [SerializeField] private GameObject echo;
    [SerializeField] private float cooldown;
    

   
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
           Shoot();
        }
        
      
    }

    void Shoot()
    {
        GameObject  attackEcho = Instantiate(echo, transform.position, quaternion.identity,null);
        StartCoroutine(SizeUp(attackEcho));

    }

    IEnumerator SizeUp(GameObject attackEcho)
    {
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        yield return new WaitForSeconds(cooldown);
        attackEcho.transform.localScale += Vector3.one;
        Destroy(attackEcho);
       
    }
}
