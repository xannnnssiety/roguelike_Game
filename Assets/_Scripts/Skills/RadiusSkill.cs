using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusSkill : MonoBehaviour
{
    public static int damageAmount;
    public float radius = 2f;
    public static float damageInterval;

    public LayerMask damageableLayers;

    private bool isUsingAbility = false;

    

    private void Start()
    {
        damageAmount = 50;
        damageInterval = 1f;
        UseAbility(); // автоматически активируем способность при запуске игры

    }

    public void UseAbility()
    {
        if (isUsingAbility)
        {

            return;
        }
        

        isUsingAbility = true;

        StartCoroutine(DamageOverTime());
    }

    public IEnumerator DamageOverTime()
    {
        while (isUsingAbility)
        {
            Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, radius, damageableLayers);

            foreach (Collider2D hitCollider in hitColliders)
            {
                
                hitCollider.GetComponent<Enemy>().TakeDamage(damageAmount);


            }

            yield return new WaitForSeconds(damageInterval);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
