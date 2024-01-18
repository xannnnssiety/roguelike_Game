using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffMenu : MonoBehaviour
{
    public void BuffHP()
    {
        Player.playerHealth += 10;
  /*      PlayerPrefs.SetInt("PlayerHP", Player.playerHealth);*/
    }

    public void BuffHPSec()
    {

    }

    public void BuffDamage()
    {
        bullet.damageBullet += 1;
        BulletNew.damage += 1;
        RadiusSkill.damageAmount += 1;

/*        PlayerPrefs.SetInt("DamageBullet", bullet.damageBullet);
        PlayerPrefs.SetInt("DamageBulletNew", BulletNew.damage);
        PlayerPrefs.SetInt("DamageRadius", RadiusSkill.damageAmount);*/
    }

    public void BuffSpeed()
    {
        
        RadiusSkill.damageInterval -= 0.025f;
        Shooting.fireRate -= 0.01f;
        ShootingFireball.fireRate -= 0.05f;

        
/*        PlayerPrefs.SetFloat("RadiusSpeed", RadiusSkill.damageInterval);
        PlayerPrefs.SetFloat("ShootingSpeed", Shooting.fireRate);
        PlayerPrefs.SetFloat("FireballSpeed", ShootingFireball.fireRate);*/

    }
}
