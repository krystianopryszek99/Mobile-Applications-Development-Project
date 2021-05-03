using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// this will keep track of the score
public class GameController : MonoBehaviour
{
    // == private fields ==

    // players score, starts from 0 which then gets added each time player collects pickups
    [SerializeField] private int playerScore = 0;

    // This points to what score is needed to get to a new level, this is set in the Inspector
    [SerializeField] private int scoreToGet = 1;

    // counts the score on screen
    [SerializeField] private TextMeshProUGUI scoreCountText;

    // loads the next scene when specific score gets achieved
    private int nextSceneToLoad;

    private void Start()
    {
        // this checks the current scene and each time this gets called
        // if the player reaches the specific score then this will load the next scene on the build index
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // add the score
    public void AddToScore(int pointsToAdd)
    {
        playerScore += pointsToAdd;
        // update the score on screen
        scoreCountText.text = playerScore.ToString();

        // if player score is equal to score to get (the score to reach to get to next level)
        if (playerScore == scoreToGet) 
        {   
            // then calls the nextSceneToLoad and loads next scene
            SceneManager.LoadScene(nextSceneToLoad);
        }
        
    }

    // method for pause the game
    public void PauseGame()
    {
        // sets the time to 0, which means the whole game pauses 
        Time.timeScale = 0f;
    }

    // method for unpause
    public void UnPauseGame()
    {
        // sets the time to 1, which means the whole game resume
        Time.timeScale = 1f;
    }
}
