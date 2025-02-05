using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseGravity : MonoBehaviour
{
    private RigidBody rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision ReversePad)
    {
        rb.gravityScale *= -1;
    }

}
