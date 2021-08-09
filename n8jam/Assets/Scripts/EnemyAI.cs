using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using System.Linq;

public class EnemyAI : MonoBehaviour
{
    private enum State {Patrolling, Attacking, Chasing}

    private State _state = State.Patrolling;
    
   [SerializeField] private Vector3 startPos;

   [SerializeField] private float speed;
   private bool _moveRight = true;
   private bool _canShoot = true;
   [SerializeField] private Transform groundDetection;
   [SerializeField] private float playerCheckRadius;
   [SerializeField] private float playerAttackRadius;
   [SerializeField] private GameObject player;
   [SerializeField] private GameObject bullet;
   [SerializeField] private Transform firePoint;
    void Start()
    {
        startPos = transform.position;
    }

   
    void Update()
    {
        switch (_state)
        {
            case State.Patrolling:
                Patrol();
                break;
            case State.Attacking:
                Attacking();
                break;
            case  State.Chasing:
                Chase();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }


        Collider2D[] playerCheck = Physics2D.OverlapCircleAll(transform.position, playerCheckRadius);
        Collider2D[] playerAttack = Physics2D.OverlapCircleAll(transform.position, playerAttackRadius);


        if (playerAttack.Contains(player.GetComponent<Collider2D>()))
        {
            _state = State.Attacking;
        }
        else if (playerCheck.Contains(player.GetComponent<Collider2D>()))
        {
            _state = State.Chasing;
        }
        else
        {
            _state = State.Patrolling;

        }

        

    }

    private void Patrol()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D ray = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);

        if (ray.collider == null)
        {
            if (_moveRight)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                _moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                _moveRight = false;
            }
        }
    }

    private void Attacking()
    {
        Debug.Log("attack!");

        if (player.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (player.transform.position.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (_canShoot)
        {
            Shoot();
            _canShoot = false;
            StartCoroutine(Cooldown());
        }
    }

    private void Chase()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
        if (player.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (player.transform.position.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,playerCheckRadius);
        Gizmos.DrawWireSphere(transform.position,playerAttackRadius);
    }


    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        
        rb.AddForce(transform.right * 10f, ForceMode2D.Impulse);
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(0.5f);
        _canShoot = true;
    }
}
