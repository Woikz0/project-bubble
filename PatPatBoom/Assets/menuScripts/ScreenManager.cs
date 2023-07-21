using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject pauseScreen;
    public GameObject levelboard;
    bool lvlAcikMÝ;



    public void PouseButton()
    {
        Time.timeScale = 0;
        gameScreen.SetActive(false);
        pauseScreen.SetActive(true);

    }

    public void PlayButton()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        gameScreen.SetActive(true);
    }

    public void RePlayButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void levelPanel()
    {
        if (lvlAcikMÝ == false)
        {
            levelboard.SetActive(true);
            lvlAcikMÝ = true;
        }
        else
        {
            levelboard.SetActive(false);
            lvlAcikMÝ = false;
        }

    }
}
