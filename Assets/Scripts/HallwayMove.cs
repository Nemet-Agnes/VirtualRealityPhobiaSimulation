using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayMove : MonoBehaviour
{
    public float speed = 1.0f; // Speed of the movement
    public Vector3 targetPosition = new Vector3(0, 0, 0); // Target position

    void Update()
    {
        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
}
