using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    // == private fields ==

    // speed of the obstacles - this can be set in the inspector 
    [SerializeField] private float obstacleSpeed = 5.0f;

    // rigidbody2d
    private Rigidbody2D rb;

    private void Start()
    {
        // get the rigidbody
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        // apply velocity to the rigidbody
        rb.velocity = new Vector2(-1 * obstacleSpeed, 0);
    }

    // player collision - death
    void OnTriggerEnter2D(Collider2D other)
    {
        // if player collides with any collider, he dies 
        if(other.CompareTag("Player"))
        {
            // loads the game over menu 
            SceneManager.LoadScene("GameOverMenu");
        }
    }

}
