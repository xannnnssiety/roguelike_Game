using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFireball : MonoBehaviour
{
    public GameObject bullet;
    public static float fireRate;
    float nextFire;

    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }

}
