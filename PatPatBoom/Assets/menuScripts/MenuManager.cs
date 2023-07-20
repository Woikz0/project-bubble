using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject settingBoard;
    public GameObject levelboard;
    public AudioSource bgMusic;
    public Text valumeAmount;
    public Slider volumeSlider;
    bool acikm›;
    bool lvlAcikM›;

    private void Start()
    {
          volumeSlider.value = PlayerPrefs.GetFloat("volume");
    }

    public void PlayButton() 
    {
        SceneManager.LoadScene(0);
    
    }

    public void SettingsBoardButton()
    {
        if (acikm› == false) 
        {
        settingBoard.SetActive(true);
            acikm› = true;

        }
        else
        {
            settingBoard.SetActive(false);
            acikm›= false;
        }

    }

    public void CloseButton()
    {
        settingBoard.SetActive(false);
    }

   
    public void SetAudio(float value)
    {
        bgMusic.volume = value/100;
        PlayerPrefs.SetFloat("volume", value);
        valumeAmount.text = PlayerPrefs.GetFloat("volume").ToString();
        PlayerPrefs.Save();
    }
    
    public void levelPanel()
    {
       if(lvlAcikM›==false)
        {
            levelboard.SetActive(true);
            lvlAcikM› = true;
        }
        else
        {
            levelboard.SetActive(false);
            lvlAcikM›= false;
        }
        
       
    }

   


    public void level1()
    {
        SceneManager.LoadScene(0);
    }






}
