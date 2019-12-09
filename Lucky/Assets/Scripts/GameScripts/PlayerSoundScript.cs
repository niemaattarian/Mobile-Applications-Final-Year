using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundScript : MonoBehaviour
{

    public static AudioClip playerWalkSound, playerJumpSound, playerWeaponEquip, playerEnergyPickup, gameCheckpoint;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerWalkSound = Resources.Load<AudioClip> ("PlayerWalk");
        playerJumpSound = Resources.Load<AudioClip> ("Playerjump");
        playerWeaponEquip = Resources.Load<AudioClip> ("WeaponEquip");
        playerEnergyPickup = Resources.Load<AudioClip> ("EnergyPower");
        gameCheckpoint = Resources.Load<AudioClip> ("CheckpointCP");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public static void PlaySound (string clip){
        switch(clip) {
            case "PlayerWalk":
                audioSrc.PlayOneShot (playerWalkSound);
                break;
            case "Playerjump":
                audioSrc.PlayOneShot (playerJumpSound);
                break;
            case "WeaponEquip":
                audioSrc.PlayOneShot (playerWeaponEquip);
                break;
            case "EnergyPower":
                audioSrc.PlayOneShot (playerEnergyPickup);
                break;
            case "CheckpointCP":
                audioSrc.PlayOneShot (gameCheckpoint);
                break;
        }
    }
}