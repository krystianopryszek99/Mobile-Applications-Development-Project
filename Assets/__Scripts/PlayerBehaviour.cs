using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Player speed - how fast the player moves
    [SerializeField] private float speed = 5.0f;

    // the speed of the player jump 
    [SerializeField] private float jumpSpeed = 10.0f;

    // audio played when the player jumps
    [SerializeField] private AudioClip playerJumpSound;

    // == private fields ==
    private float xMin = -8.5f;
    private float xMax= 8.5f;
    private float yMin = -4.5f;
    private float yMax = 4.5f;

    // Rigidbody
    private Rigidbody2D rb;

    // Runs once at the start
    void Start()
    {
        // looks at the player object, get component component of type Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerMove(); 
        PlayerJump();
        
    }

    // the player move which keeps the player on screen 
    private void PlayerMove()
    {
        // constraint the player to the screen 
        float xValue = Mathf.Clamp(rb.position.x, xMin, xMax);
        float yValue = Mathf.Clamp(rb.position.y, yMin, yMax);

        // update the rigidbody
        rb.position = new Vector2(xValue, yValue);
    }

    // controls the player jump
    private void PlayerJump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Vector2 jumpVecocityToAdd = new Vector2(0, jumpSpeed);
            rb.velocity += jumpVecocityToAdd;
            // when the player jumps, this audio is played 
            AudioSource.PlayClipAtPoint(playerJumpSound, Camera.main.transform.position);
        }
      
    }
}

    

