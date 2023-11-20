using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 teleportCoord1 = new Vector3(1f, 0f, 0f);
    public Vector3 teleportCoord2 = new Vector3(0f, 1f, 0f);
    public Vector3 teleportCoord3 = new Vector3(0f, 0f, 1f);
    public Vector3 teleportCoord4 = new Vector3(2f, 2f, 2f);

    public KeyCode teleportKey = KeyCode.T;

    private int currentCoordinateIndex = 1;

    void Update()
    {
        if (Input.GetKeyDown(teleportKey))
        {
            TeleportPlayer();
        }
    }

    void TeleportPlayer()
    {
        switch (currentCoordinateIndex)
        {
            case 1:
                transform.position = teleportCoord1;
                break;
            case 2:
                transform.position = teleportCoord2;
                break;
            case 3:
                transform.position = teleportCoord3;
                break;
            case 4:
                transform.position = teleportCoord4;
                break;
        }

        // Cycle to the next set of coordinates
        currentCoordinateIndex = (currentCoordinateIndex % 4) + 1;
    }
}
