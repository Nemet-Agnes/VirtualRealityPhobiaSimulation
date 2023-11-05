using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float movementSpeed = 5.0f;

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(horizontalMovement, 0, verticalMovement);
        transform.Translate(moveDirection);
    }
}
