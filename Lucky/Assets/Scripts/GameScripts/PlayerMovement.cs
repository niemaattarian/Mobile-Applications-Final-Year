using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded = false;
    public bool canDoubleJump;
    // Sprite rendering
    private SpriteRenderer renderer;
    private Sprite playerAxe;
    public Animator playerAnim;
   
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    
    }
    
    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");

        //PlayerSounds.PlaySound ("PlayerWalk");
        if (Input.GetButtonDown ("Jump"))
        {
            if(isGrounded == true)
            {
                // Player Jumping sounds
                PlayerSoundScript.PlaySound ("Playerjump");
                //Calling player jump
                Jump();
                canDoubleJump = true;
            }
            else{
                if(canDoubleJump)
                {
                    // Plays jump sound
                    PlayerSoundScript.PlaySound ("Playerjump");
                    canDoubleJump = false;
                    GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
                    GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
                }
            }
        }
        //Animation
        //Player Direction
        Vector3 playerScale = transform.localScale;
        
        // Player flip
        if (Input.GetAxis("Horizontal") < 0)
        {
            playerScale.x = -0.9f;
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            playerScale.x = 0.9f;
        }
        transform.localScale = playerScale;

        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    // Player Jump
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
            // Changes player speed
            playerJumpPower = 2000;
            // Changes the color of the player to signify the power up change
            GetComponent<SpriteRenderer>().color = Color.yellow;
            // Reset Player
            StartCoroutine(ResetPower());
        }

        if(other.gameObject.CompareTag("Axe"))
        {
            // Plays the sound for Weapon pickup
            PlayerSoundScript.PlaySound ("WeaponEquip");
            // Destroys the object once taken
            Destroy(other.gameObject);
            // Changes player sprite
            renderer = GetComponent<SpriteRenderer>();
            playerAxe = Resources.Load<Sprite> ("MC-axe");
            renderer.sprite = playerAxe;
            playerAnim.SetTrigger("Swing");
        }
        
        if(other.gameObject.CompareTag("Checkpoint"))
        {
            // Plays the sound for Checkpoint
            PlayerSoundScript.PlaySound ("CheckpointCP");
            // Destroys the object once taken
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Coins"))
        {
            // Plays the sound for Checkpoint
            PlayerSoundScript.PlaySound ("Coin");
            // Destroys the object once taken
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Gun"))
        {
            // Plays the sound for Checkpoint
            PlayerSoundScript.PlaySound ("Gun");
            // Destroys the object once taken
            Destroy(other.gameObject);
        }
    }
  
    // Adapted from https://www.youtube.com/watch?v=0BrltbzgTYo
    private IEnumerator ResetPower()
    {
        // This waits 10 seconds before power up is gone
        yield return new WaitForSeconds(6);
        // Add back to regular speed and jump 
        playerJumpPower = 1250;
        // Returns back to egular sprite
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}