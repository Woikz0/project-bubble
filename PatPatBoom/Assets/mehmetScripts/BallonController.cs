using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2.5f;
    public Animator anim;
    public string animAD;
    public AudioSource ses;
    public AudioClip[] clip;
    bool isClicked = false;
    
   
    void Start()
    {
      
        ses = GetComponent<AudioSource>();
    }

    void Update()
    {
        rb.velocity = new Vector2(0,speed);


    }
    private void OnMouseDown()
    {
        if(isClicked==false)
        {
            anim.Play(animAD);
            AudioClip rastgeleses = clip[Random.Range(0, clip.Length)];
            ses.PlayOneShot(rastgeleses);
            Destroy(this.gameObject, 0.4f);
            isClicked = true;
        }

    }
}
