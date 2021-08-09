using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private float offsetX, offsetY;

    [SerializeField] private Health deathCheck;

   
    private void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, player.position.y + offsetY, transform.position.z);


        if (deathCheck._isDead)
        {
            SceneManager.LoadScene(1); 
        }
    }
}
