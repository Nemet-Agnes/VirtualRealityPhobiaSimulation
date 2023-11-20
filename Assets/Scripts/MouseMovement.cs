using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Camera playerCamera;

    private float xMousePos;
    private float yMousePos;

    private float xRotation;
    private float yRotation;

    private float sensitivity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

            GetInput();
            MovePlayer();
            LockCursor();
    }

    void GetInput()
    {
        xMousePos = Input.GetAxisRaw("Mouse X");
        yMousePos = Input.GetAxisRaw("Mouse Y");
    }

    void MovePlayer()
    {
        xRotation += yMousePos * sensitivity;
        yRotation += xMousePos * sensitivity;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
    }
    void LockCursor()
    {
            Cursor.lockState = CursorLockMode.Locked;
    }
    private void LateUpdate()
    {
        playerCamera.transform.localRotation = Quaternion.Euler(-xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}