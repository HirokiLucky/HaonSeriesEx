using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanScript : MonoBehaviour
{
    private Rigidbody rb;
    private Animator animator;
    private float speed = 20.0f;
    private static readonly int Speed = Animator.StringToHash("speed");

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger(Speed, 2);
        } else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger(Speed, 1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetInteger(Speed, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetInteger(Speed, 2);
        } else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger(Speed, 1);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetInteger(Speed, 0);
        }
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        Vector3 v = new Vector3(x, 0, 0);
        rb.AddForce(v);
    }
}
