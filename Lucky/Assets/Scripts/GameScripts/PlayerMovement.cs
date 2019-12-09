using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;

    // Sprite rendering
    private SpriteRenderer renderer;
    private Sprite playerAxe;


    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        // Player Walking sounds
 //       PlayerSoundScript.PlaySound ("PlayerWalk");
        //Controls
        moveX = Input.GetAxis("Horizontal");

        //PlayerSounds.PlaySound ("PlayerWalk");
        if (Input.GetButtonDown ("Jump"))
        {
            // Player Jumping sounds
            PlayerSoundScript.PlaySound ("Playerjump");
            
            //Calling player jump
            Jump();
        }
        //Animation
        //Player Direction
        Vector3 playerScale = transform.localScale;
        if (moveX < 0.0f && facingRight == false)
        {
            
            playerScale.x = -0.9f;
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            
            playerScale.x = 0.9f;
        }
        transform.localScale = playerScale;

        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //Jumping
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("EnergyPickup"))
        {
            // Plays the sound for power up
            PlayerSoundScript.PlaySound ("EnergyPower");
            // Destroys the object once taken
            Destroy(other.gameObject);
            // Changes the color of the player to signify the power up change
            GetComponent<SpriteRenderer>().color = Color.yellow;
            // Reset Player
            StartCoroutine(ResetPower());
        }

        if(other.gameObject.CompareTag("Axe"))
        {
            PlayerSoundScript.PlaySound ("WeaponEquip");
            Destroy(other.gameObject);
            renderer = GetComponent<SpriteRenderer>();
            playerAxe = Resources.Load<Sprite> ("MC-axe");
            renderer.sprite = playerAxe;
        }
        
        if(other.gameObject.CompareTag("Checkpoint"))
        {
            PlayerSoundScript.PlaySound ("CheckpointCP");
            Destroy(other.gameObject);
        }
    }
    
    // void PlayerHealth()
    // {
    //         if(Health.playerHealth == 0)
    //         {
    //             transform.position = spawnPoint.position;
    //         }
    // }

    // Adapted from https://www.youtube.com/watch?v=0BrltbzgTYo
    private IEnumerator ResetPower()
    {
        // This waits 10 seconds before power up is gone
        yield return new WaitForSeconds(6);
        /* ====================== TODO ==========================*/
        // Add back to regular speed and jump 

        // Returns back to egular sprite
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}
