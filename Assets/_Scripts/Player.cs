using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int playerHealth;
    public int playerHP = 100;
    public Text playerHealthText;

    public static int EXP;

    public AudioSource pickup;

    public Text EXPtext;
    /*public Text maxEXPText;*/
    public Text lvlText;

    public GameObject Wave1;
    public GameObject Wave2;
    public GameObject Wave3;
    public GameObject BossWave;

    public GameObject GameOverCanv;


    void Start()
    {
        GameOverCanv.SetActive(false);
/*        Wave1.SetActive(false);
        Wave2.SetActive(false);
        Wave3.SetActive(false);*/
        BossWave.SetActive(false);
        EXP = 0;
        playerHealth = playerHP;

        EXPmanager.lvl = 1;
        EXPmanager.maxEXP = 10;

        Invoke("SpawnLastBoss", 900f);
    }

    
    void Update()
    {
        

        playerHealthText.text = playerHealth.ToString();
        EXPtext.text = EXP.ToString() + "/" + EXPmanager.maxEXP.ToString();
        /*maxEXPText.text = EXPmanager.maxEXP.ToString();*/
        lvlText.text = EXPmanager.lvl.ToString();

        if (EXPmanager.lvl >= 2)
        {
            Wave1.SetActive(true);
            EXPmanager.EXPcount = 2;
            GameManager.MoneyDrop = 2;
        }
        if (EXPmanager.lvl >= 7)
        {
            EXPmanager.EXPcount = 2;
            GameManager.MoneyDrop = 2;
        }
        if (EXPmanager.lvl >= 20)
        {
            Wave2.SetActive(true);
            EXPmanager.EXPcount = 3;
            GameManager.MoneyDrop = 3;
        }
        if(EXPmanager.lvl >= 50)
        {
            Wave3.SetActive(true);
            EXPmanager.EXPcount = 4;
            GameManager.MoneyDrop = 4;
        }


        if (playerHealth <= 0)
        {
            GameOverCanv.SetActive(true);
            Time.timeScale = 0;
            
        }

        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EXP"))
        {
            pickup.Play();
            
            /*Destroy(gameObject);*/ /*Должен удаляться */
        }
    }

    public void SpawnLastBoss()
    {
        BossWave.SetActive(true);
        BlockButton.levelComplete += 1;
        PlayerPrefs.SetInt("lvlComplete", BlockButton.levelComplete);
        CancelInvoke("SpawnLastBoss");
    }


}
