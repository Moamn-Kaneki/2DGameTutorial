using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator animator;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {  
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        if(direction != 0)
        {
            animator.SetBool("Run",true);
        } 
        else
        {
            animator.SetBool("Run",false);
        }
        if(direction < 0)
        {
            transform.rotation = new Quaternion(0,180,0,0);
        }
        else if(direction > 0 )
        {
            transform.rotation = new Quaternion(0,0,0,0);
        }
        transform.position += new Vector3(direction*Time.deltaTime*speed, 0, 0);
    }
}
