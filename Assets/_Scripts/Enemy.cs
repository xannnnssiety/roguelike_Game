using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
 

    public int healthEnemy;
    public int damageEnemy;

    public static int damageNew;

    public GameObject expDrop;

    protected Transform m_Transform;

    public GameObject death;







    void Start()
    {

        damageNew = 15;


    }

    void Update()
    {
        
        if (healthEnemy <= 0)
        {
            Destroy(gameObject);
            SpawnEnemy.nowTheEnemies--;
            KillCount.killCount++;
            GameManager.Money += GameManager.MoneyDrop;
            GameObject Item = Instantiate(expDrop, transform.position, Quaternion.identity);

            EarnGameOver.MoneyEarn++;

            PlayerPrefs.SetInt("Money", GameManager.Money);

            GameObject deathRef = Instantiate(death);
            deathRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }





    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnEnemyAttack();
        }
    }

    public void OnEnemyAttack()
    {
        Player.playerHealth -= damageEnemy;
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            healthEnemy -= bullet.damageBullet;

            
        }

    }

    public void TakeDamage(int damage)
    {
        damage = damageNew;
        healthEnemy -= damage;
        

    }




}
