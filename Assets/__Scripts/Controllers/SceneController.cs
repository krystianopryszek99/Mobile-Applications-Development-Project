using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    // loads next scene in build index
    private int nextSceneToLoad;
    
    private void Start()
    {
        // loads next scene in build index and loads the next scene on the build index
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // onClick handlers

    // to load scene called Level 1 - takes player to level one when this onClick gets called
    public void Start_OnClick()
    {
        // loads scene Level 1
        SceneManager.LoadScene("Level 1");
    }

    // when players clicks it will take him to the intro level 
    public void Intro_OnClick()
    {
        // loads the intro level
        SceneManager.LoadScene("Intro Level");
    }

    // main menu - takes player to the main menu
    public void MainMenu_OnClick()
    {
        // loads scene called Start Menu
        SceneManager.LoadScene("StartMenu");
    }

    // Back - When this gets clicked, the player goes back to the game that he is currently in,
    // if player is on e.g. level 3 and calls this onClick, then when he unpauses the game,
    // he will be then taken back to level 3
    public void Back_OnClick()
    {
        // find the object of type GameController and calls UnPauseGame with unpauses the game
        FindObjectOfType<GameController>().UnPauseGame();
        // Unloads the scene 
        SceneManager.UnloadSceneAsync("PauseMenu");
    }

    // Restart game - this restarts the game back to Level 1
    // if player is on level 3 and restarts the game, then he will be taken back to level 1
    public void RestartGame()
    {
        // unpause the game before loading level 1 
        FindObjectOfType<GameController>().UnPauseGame();
        // loads scene called Level 1
        SceneManager.LoadScene("Level 1");
    }

    
}
