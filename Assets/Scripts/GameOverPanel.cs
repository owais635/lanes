using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    private const string GAMEPLAY_SCENE_NAME = "Gameplay";

    public void RestartGame()
    {
        SceneManager.LoadScene (GAMEPLAY_SCENE_NAME);
    }
}
