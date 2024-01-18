using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public static float fireRate;
    float nextFire;
    
    void Start()
    {
        fireRate = 0.5f;
        nextFire = Time.time;
    }

    
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }


}
