using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public int hp = 1;
    public int scoreValue;
    public bool isEnemy = false;

    public void damage(int damageCount)
    {
        hp -= damageCount;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D otherCollider)
    {       
            if (hp <= 0)
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                Destroy(gameObject);
            }
        }
    }


