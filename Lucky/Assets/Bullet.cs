using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rigidbody;
    public int shotgundamage = 30;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Rat rat = hitInfo.GetComponent<Rat>();
        Wolf wolf = hitInfo.GetComponent<Wolf>();
        Bear bear = hitInfo.GetComponent<Bear>();
        if(rat != null)
        {
            PlayerSoundScript.PlaySound ("RatDeath");
            rat.TakeDamage(shotgundamage);
        }
        
        if(wolf != null)
        {
            PlayerSoundScript.PlaySound ("DogBark");
            wolf.TakeDamage(shotgundamage);
        }

        if(bear != null)
        {
            PlayerSoundScript.PlaySound ("Growl");
            bear.TakeDamage(shotgundamage);
        }
        Destroy(gameObject);
    }
}
