using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // Changes spawn point of player when he dies
    [SerializeField]Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.CompareTag("Player"))
        {
            // Plays death sound
            PlayerSoundScript.PlaySound ("PlayerDeath");
            // moves player to spawnpoint when dead
            col.transform.position = spawnPoint.position;
        }
    }
}
