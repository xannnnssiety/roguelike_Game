using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletNew : MonoBehaviour
{
    public float speed;
    public static int damage;

    private Transform target;

    void Start()
    {
        speed = 10f;
        damage = 10;
        FindClosestEnemy();
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 direction = target.position - transform.position;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        Transform closestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector2.Distance(transform.position, enemy.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy.transform;
            }
        }

        target = closestEnemy;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
