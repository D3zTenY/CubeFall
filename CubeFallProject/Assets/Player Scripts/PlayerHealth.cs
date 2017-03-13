using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        bool damagePlayer = false;

        EnemyMovement enemy = collision.gameObject.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            HealthScript enemyHealth = enemy.GetComponent<HealthScript>();
            if (enemyHealth != null) enemyHealth.damage(enemyHealth.hp);
            damagePlayer = true;
        }
        {
            if (damagePlayer)
            {
                HealthScript playerHealth = this.GetComponent<HealthScript>();
                if (playerHealth != null) playerHealth.damage(1);
            }
        }
    }
}
