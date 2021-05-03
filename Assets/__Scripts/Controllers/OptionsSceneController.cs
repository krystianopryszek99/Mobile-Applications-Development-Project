using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsSceneController : MonoBehaviour
{
    public void Back_OnClick()
    {
        SceneManager.UnloadSceneAsync("Options");
    }
}
