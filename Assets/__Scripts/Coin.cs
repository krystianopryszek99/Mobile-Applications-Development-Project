using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // coin speed is the speed of the pickups
    [SerializeField] private float coinSpeed = 0.01f;

    // sound when the player picks up a reward eg bread 
    [SerializeField] private AudioClip coinPickUpSound;
    
    // the score of the pickup, this can be set to different score in the inspector
    // different level, different score per pickup
    [SerializeField] private int pointsForCoin = 1; 

    // Rigidbody2D
    private Rigidbody2D rb;

    // == public fields ==
    private void Start()
    {
        // get the rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // apply velocity to the rigidbody
        rb.velocity = new Vector2(-1 * coinSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //give score
        FindObjectOfType<GameController>().AddToScore(pointsForCoin);
        //this.GetComponent<AudioSource>().PlayOneShot(coinPickUpSound);
        AudioSource.PlayClipAtPoint(coinPickUpSound, Camera.main.transform.position);
        // destroy coin when collided
        Destroy(gameObject);    
    }
}
