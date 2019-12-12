using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundScript : MonoBehaviour
{

    public static AudioClip playerWalkSound, playerJumpSound, playerWeaponEquip, playerEnergyPickup, gameCheckpoint, coinPickup, shotgunSound, gunPickup, playerDeath, 
    ratDeath, bossDeath, wolfDeath;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        // Loading audio clips of players, these can be found here https://opengameart.org/art-search-advanced?keys=sounds&title=&field_art_tags_tid_op=or&field_art_tags_tid=&name=&field_art_type_tid%5B%5D=9&field_art_type_tid%5B%5D=10&field_art_type_tid%5B%5D=7273&field_art_type_tid%5B%5D=14&field_art_type_tid%5B%5D=12&field_art_type_tid%5B%5D=13&field_art_type_tid%5B%5D=11&field_art_licenses_tid%5B%5D=17981&field_art_licenses_tid%5B%5D=2&field_art_licenses_tid%5B%5D=17982&field_art_licenses_tid%5B%5D=3&field_art_licenses_tid%5B%5D=6&field_art_licenses_tid%5B%5D=5&field_art_licenses_tid%5B%5D=10310&field_art_licenses_tid%5B%5D=4&field_art_licenses_tid%5B%5D=8&field_art_licenses_tid%5B%5D=7&sort_by=score&sort_order=DESC&items_per_page=24&Collection=
        playerWalkSound = Resources.Load<AudioClip> ("PlayerWalk");
        playerJumpSound = Resources.Load<AudioClip> ("Playerjump");
        playerWeaponEquip = Resources.Load<AudioClip> ("WeaponEquip");
        playerEnergyPickup = Resources.Load<AudioClip> ("EnergyPower");
        gameCheckpoint = Resources.Load<AudioClip> ("CheckpointCP");
        coinPickup = Resources.Load<AudioClip> ("Coin");
        shotgunSound = Resources.Load<AudioClip> ("Shotgun");
        gunPickup = Resources.Load<AudioClip> ("Gun");
        playerDeath = Resources.Load<AudioClip> ("PlayerDeath");
        ratDeath = Resources.Load<AudioClip> ("RatDeath");
        bossDeath = Resources.Load<AudioClip> ("Growl");
        wolfDeath = Resources.Load<AudioClip> ("DogBark");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Plays each sound clip based on specific action
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
            case "Coin":
                audioSrc.PlayOneShot (coinPickup);
                break;
            case "Shotgun":
                audioSrc.PlayOneShot (shotgunSound);
                break;
            case "Gun":
                audioSrc.PlayOneShot (gunPickup);
                break;
            case "PlayerDeath":
                audioSrc.PlayOneShot (playerDeath);
                break;
            case "RatDeath":
                audioSrc.PlayOneShot (ratDeath);
                break;
            case "Growl":
                audioSrc.PlayOneShot (bossDeath);
                break;
            case "DogBark":
                audioSrc.PlayOneShot (wolfDeath);
                break;
        }
    }
}