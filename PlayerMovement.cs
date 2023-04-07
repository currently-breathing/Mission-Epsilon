using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {

        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);



        if (Input.GetButtonDown("Jump")){
            rb.velocity = new Vector2(rb.velocity.x,14f);
        }

        if (dirX > 0f){
            anim.SetBool("Running", true);
            sprite.flipX = false;

        }
        else if(dirX < 0f){
            anim.SetBool("Running", true);
            sprite.flipX = true;
        }
        else{
            anim.SetBool("Running", false);
        }
    }
}