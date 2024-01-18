using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed;
    public static int damageBullet;
    Rigidbody2D rb;
    private Transform target;
    Vector2 moveDirection;

    void Start()
    {
        damageBullet = 50;



        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        


    }

    public void Update()
    {
        Destroy(gameObject, 3f);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            
        }
    }

}
