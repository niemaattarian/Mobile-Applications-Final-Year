using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    // Boss health
    public int health = 40;
    // Take damage method from gun
    public void TakeDamage (int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    // Die method when health is 0
    void Die()
    {
        Destroy(gameObject);
    }
}
