using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanScript : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 20.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        Vector3 v = new Vector3(x, 0, 0);
        rb.AddForce(v);
    }

    // private void FixedUpdate()
    // {
    //     
    // }
}
