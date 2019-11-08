using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Health.playerHealth -= 5f;
    }
}
