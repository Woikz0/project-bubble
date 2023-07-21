using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadControl : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject gameScreen;
    public GameObject over;
    public GameObject star;


    void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison)
        {
            Debug.Log("etki");
            targetObject.SetActive(true);
            gameScreen.SetActive(true);

        }

    }














}






