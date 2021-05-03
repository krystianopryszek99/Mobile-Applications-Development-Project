using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSceneController : MonoBehaviour
{
    // UI methods for pause scene 

    public void Back_OnClick()
    {
        // finds object of type GameController and calls the UnPauseGame
        FindObjectOfType<GameController>().UnPauseGame();
        // if the game is paused, then this unloads the scene 
        SceneManager.UnloadSceneAsync("PauseMenu");
    }

    public void RestartGame()
    {
        // unpause the game before loading level 1 
        // finds object of type GameController and calls the UnPauseGame
        FindObjectOfType<GameController>().UnPauseGame();
        SceneManager.LoadScene("Level 1");
    }
}
