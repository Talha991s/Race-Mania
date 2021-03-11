using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void TrackSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Track01()
    {
        SceneManager.LoadScene(2);
    }
    public void BacktoMain()
    {
        SceneManager.LoadScene(0);
    }
}
