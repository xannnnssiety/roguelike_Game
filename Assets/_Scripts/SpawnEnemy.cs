using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] spawnEnemy;
    public Transform[] spawnPoint;

    public float startSpawnerInterval;
    private float spawnerInterval;

    public int numberOfEnemies;
    public static int nowTheEnemies;

    private int randEnemy;
    private int randPoint;

    
    void Start()
    {
        
        spawnerInterval = startSpawnerInterval;   
    }

    
    void Update()
    {
        

        if (spawnerInterval <= 0 && nowTheEnemies < numberOfEnemies)
        {
            randEnemy = Random.Range(0, spawnEnemy.Length);
            randPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(spawnEnemy[randEnemy], spawnPoint[randPoint].transform.position, Quaternion.identity);

            spawnerInterval = startSpawnerInterval;
            nowTheEnemies++;
        }
        else
        {
            spawnerInterval -= Time.deltaTime;
        }

        if (EXPmanager.lvl >= 5)
        {
            startSpawnerInterval = 0.5f;
        }
        if (EXPmanager.lvl >= 15)
        {
            startSpawnerInterval = 0.3f;
        }
        if (EXPmanager.lvl >= 20)
        {
            startSpawnerInterval = 0.1f;
        }

    }
}
