using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private float offsetX, offsetY;


    private void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, player.position.y + offsetY, transform.position.z);

    }
}
