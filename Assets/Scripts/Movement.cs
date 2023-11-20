using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody playerRigidb;

    public float speed = 0.02f;

    void Update()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        playerRigidb.AddForce(speed * (transform.forward * z + transform.right * x), ForceMode.VelocityChange);
    }
}