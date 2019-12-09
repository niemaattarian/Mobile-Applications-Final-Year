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
        if(rat != null)
        {
            rat.TakeDamage(shotgundamage);
        }
        Destroy(gameObject);
    }
}
