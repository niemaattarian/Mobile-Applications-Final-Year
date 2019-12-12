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
        // Bullet tragectory
        rigidbody.velocity = transform.right * speed;
    }

    // Bullet hitting enemies
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        // Hit info on what enemies the bullet hits
        Rat rat = hitInfo.GetComponent<Rat>();
        Wolf wolf = hitInfo.GetComponent<Wolf>();
        Bear bear = hitInfo.GetComponent<Bear>();

        if(rat != null)
        {
            // Rat Death sounds
            PlayerSoundScript.PlaySound ("RatDeath");
            // Rat takes damage from the shotgun bullet
            rat.TakeDamage(shotgundamage);
        }
        
        if(wolf != null)
        {
            // Wolf Death sounds
            PlayerSoundScript.PlaySound ("DogBark");
            // Wolf takes damage from the shotgun bullet
            wolf.TakeDamage(shotgundamage);
        }

        if(bear != null)
        {
            // Boss Death sounds
            //PlayerSoundScript.PlaySound ("Growl");
            // boss takes damage from the shotgun bullet
            bear.TakeDamage(shotgundamage);
        }
        // When adequate damage is given to enemy they are destroyed
        Destroy(gameObject);
    }
}
