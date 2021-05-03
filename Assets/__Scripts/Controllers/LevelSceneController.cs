using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSceneController : MonoBehaviour
{
    // pause - allows the player to pause the game
    public void Pause_OnClick()
    {
        // pause the game and loads the Pause menu 
        // finds object of type GameController and calls the pause game
        FindObjectOfType<GameController>().PauseGame();
        // loads pause menu 
        SceneManager.LoadSceneAsync("PauseMenu", LoadSceneMode.Additive);
    }
}
