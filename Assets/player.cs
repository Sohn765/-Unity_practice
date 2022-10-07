using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float addf;
    float moveX;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer src;
    public int jumpcount = 1;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        src = gameObject.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        animator.SetFloat("moveX", Mathf.Abs(moveX));
        if(moveX == -1) src.flipX = true;
        if (moveX == 1) src.flipX = false;

        if (jumpcount == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * addf, ForceMode2D.Impulse);
                animator.SetBool("jump", true);
                jumpcount = 0;
            }
            
        }
        
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("jump", false);
    }
}
