using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoPlayer : MonoBehaviour
{
    public Text speedPlayer;

    public Text DamageBullet;
    public Text DamageRadius;
    public Text DamageFireball;

    public Text FirerateBullet;
    public Text FirerateRadius;
    public Text FirerateFireball;

    // Update is called once per frame
    void Update()
    {
        speedPlayer.text = PlayerController.speed.ToString();

        DamageBullet.text = BulletNew.damage.ToString();
        DamageRadius.text = RadiusSkill.damageAmount.ToString();
        DamageFireball.text = bullet.damageBullet.ToString();

        FirerateBullet.text = Shooting.fireRate.ToString();
        FirerateRadius.text = RadiusSkill.damageInterval.ToString();
        FirerateFireball.text = ShootingFireball.fireRate.ToString();

    }
}
