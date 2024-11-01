using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 5f;
    private Rigidbody rb = null;
    private bool onGround = true;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) == true && onGround == true)
        {
            onGround = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }

    }

    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}

