using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public int Scenes;
    public int currentScene;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        Scenes = SceneManager.sceneCountInBuildSettings;

        currentScene = 0;

        // SceneManager.LoadScene(0);
    }

    public void OpenMiniGame1()
    {
        currentScene = 1;

        SceneManager.LoadScene(1);
    }

    public void OpenMiniGame2()
    {
        currentScene = 2;

        SceneManager.LoadScene(2);
    }

    public void Replay()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void MainMenuReturn()
    {
        currentScene = 0;

        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
