using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScript : MonoBehaviour
{
    public GameObject BuffCanvas;
    public static bool GameIsPaused = false;

    public Button ShootBTN1;
    public Button ShootBTN2;
    public Button ShootBTN3;
    public Button ShootBTN4;

    public Button AreaBTN1;
    public Button AreaBTN2;
    public Button AreaBTN3;
    public Button AreaBTN4;

    public Button FireballBTN1;
    public Button FireballBTN2;
    public Button FireballBTN3;
    public Button FireballBTN4;

    public GameObject shootPos1;
    public GameObject shootPos2;
    public GameObject shootPos3;
    public GameObject shootPos4;

    public GameObject areaDamage1;
    public GameObject areaDamage2;
    public GameObject areaDamage3;
    public GameObject areaDamage4;

    public GameObject fireball1;
    public GameObject fireball2;
    public GameObject fireball3;
    public GameObject fireball4;

    public GameObject SpeedBTN;

    private void Start()
    {
        SpeedBTN.SetActive(true);
        BuffCanvas.SetActive(false);

        ShootBTN2.interactable = false;
        ShootBTN3.interactable = false;
        ShootBTN4.interactable = false;

        AreaBTN2.interactable = false;
        AreaBTN3.interactable = false;
        AreaBTN4.interactable = false;

        FireballBTN2.interactable = false;
        FireballBTN3.interactable = false;
        FireballBTN4.interactable = false;

    }

    private void Update()
    {
        if (Player.EXP >= EXPmanager.maxEXP)
        {
            Player.EXP = 0;
            EXPmanager.maxEXP += 5;
            EXPmanager.lvl += 1;
            Pause();

        }



    }

    void Resume()
    {
        BuffCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        BuffCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void BuyShoot1()
    {
        shootPos1.SetActive(true);
        Resume();

        ShootBTN1.interactable = false;
        ShootBTN2.interactable = true;
    }

    public void BuyShoot2()
    {
        shootPos2.SetActive(true);
        Resume();

        ShootBTN2.interactable = false;
        ShootBTN3.interactable = true;
    }

    public void BuyShoot3()
    {
        shootPos3.SetActive(true);
        Resume();

        ShootBTN3.interactable = false;
        ShootBTN4.interactable = true;
    }

    public void BuyShoot4()
    {
        shootPos4.SetActive(true);
        Resume();

        ShootBTN4.interactable = false;
    }

    public void BuyArea1()
    {
        areaDamage1.SetActive(true);
        Resume();

        AreaBTN1.interactable = false;
        AreaBTN2.interactable = true;
    }

    public void BuyArea2()
    {
        areaDamage2.SetActive(true);
        Resume();

        AreaBTN2.interactable = false;
        AreaBTN3.interactable = true;
    }

    public void BuyArea3()
    {
        areaDamage3.SetActive(true);
        Resume();

        AreaBTN3.interactable = false;
        AreaBTN4.interactable = true;
    }

    public void BuyArea4()
    {
        areaDamage4.SetActive(true);
        Resume();

        AreaBTN4.interactable = false;
    }

    public void BuyFireball1()
    {
        fireball1.SetActive(true);
        Resume();

        FireballBTN1.interactable = false;
        FireballBTN2.interactable = true;
    }

    public void BuyFireball2()
    {
        fireball2.SetActive(true);
        Resume();

        FireballBTN2.interactable = false;
        FireballBTN3.interactable = true;
    }

    public void BuyFireball3()
    {
        fireball3.SetActive(true);
        Resume();

        FireballBTN3.interactable = false;
        FireballBTN4.interactable = true;
    }

    public void BuyFireball4()
    {
        fireball4.SetActive(true);
        Resume();

        FireballBTN4.interactable = false;
    }

    public void buyIntelegence()
    {
        /*bullet.damageBullet += 1;*/
        RadiusSkill.damageAmount += 1;
        BulletNew.damage += 1;
        Resume();
    }

    public void buyPower()
    {
        Player.playerHealth += 50;
        Resume();
    }

    public void buySpeed()
    {
        PlayerController.speed += 0.2f;
        Shooting.fireRate -= 0.04f;
        /*ShootingFireball.fireRate -= 0.2f;*/
        RadiusSkill.damageInterval -= 0.1f;

        if (RadiusSkill.damageInterval <= 0.15f)
        {
            SpeedBTN.SetActive(false);

        }
        Resume();
    }



}
