using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject settingBoard;
    public GameObject levelboard;
    

    public void PlayButton() 
    {
        SceneManager.LoadScene(0);
    
    }

    public void SettingsBoardButton()
    {
        settingBoard.SetActive(true);
    }

    public void CloseButton()
    {
        settingBoard.SetActive(false);
    }

    public Text valumeAmount;
    public void SetAudio(float value)
    {
        AudioListener.volume = value;
        valumeAmount.text=((int)(value * 100)).ToString();
    }
    
    public void levelPanel()
    {
        levelboard.SetActive(true);
    }

    public void levleboardclose()
    {
        levelboard.SetActive(false);
    }


    public void level1()
    {
        SceneManager.LoadScene(0);
    }






}
