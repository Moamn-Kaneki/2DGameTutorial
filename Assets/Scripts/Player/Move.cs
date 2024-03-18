using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    public float speed = 3f;
    float directionX;
    // Start is called before the first frame update
    void Start()
    {  
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed*directionX,rb.velocity.y);  
    }
    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("DirectionX",Math.Abs(directionX));
        if(directionX < 0)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        else if(directionX > 0 )
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
