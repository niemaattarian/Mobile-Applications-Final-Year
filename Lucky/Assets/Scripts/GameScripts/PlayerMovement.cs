using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = true;
    public int playerJumpPower = 1250;
    private float moveX;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
       
    }

    

    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown ("Jump"))
        {
            Jump();
        }
        //Animation

        //Player Direction
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }

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
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Axe"))
        {
            Destroy(other.gameObject);
        }
    }
    
    void FlipPlayer()
    {

    }

}
