using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class GameManager : MonoBehaviour
{
    bool acik = false;
    public GameObject pausePanel;
    void Start()
    {

    }

    void Update()
    {

    }


    public void pause()
    {
        if (acik == false)
        {
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
            acik = true;
        }
        else
        {
            Time.timeScale = 1f;
            pausePanel.SetActive(false);
            acik = false;
        }

    }

    
}
