using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    private bool isClicked = false;
    public Text starText;

    void Start()
    {
        
    }

    void Update()
    {
        rb.velocity = new Vector2(0,speed);
        
    }
    private void OnMouseDown()
    {
        if(!isClicked&& Time.timeScale > 0f)
        {
            //starText.text = 1.ToString();
            Destroy(this.gameObject, 0.4f);
            isClicked=true;

        }
    }
}
