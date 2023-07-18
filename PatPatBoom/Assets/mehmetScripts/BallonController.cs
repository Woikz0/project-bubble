using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2.5f;
    public Animator anim;
    public string animAD;
    
   
    void Start()
    {
        
    }

    void Update()
    {
        rb.velocity = new Vector2(0,speed);


    }
    private void OnMouseDown()
    {


        anim.Play(animAD);
        
        Destroy(this.gameObject,0.4f);
    }
}
