﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    public int health = 80;
    //public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // void OnTriggerEnter2D(Collider2D col)
    // {
    //     Health.playerHealth -= 5f;
    // }
}
