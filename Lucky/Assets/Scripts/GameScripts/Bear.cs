using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    // Boss health
    public int health = 100;
    
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
