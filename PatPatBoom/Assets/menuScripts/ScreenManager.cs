using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject pauseScreen;


    public void PouseButton()
    {
        Time.timeScale=0;
        gameScreen.SetActive(false);
        pauseScreen.SetActive(true);

    }

    public void PlayButton()
    {
        Time.timeScale=1;
        pauseScreen.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void RePlayButton()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }

    public void HomeButton()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(1);
    }

}
