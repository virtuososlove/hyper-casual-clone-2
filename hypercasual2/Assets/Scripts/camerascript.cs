using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    // The target object that the camera should follow
    public Transform target;

    // The distance from the camera to the target
    public float distance = 10.0f;

    // The height of the camera above the target
    public float height = 5.0f;

    // The damping factor for the camera's movement
    public float damping = 1.0f;

    // The initial scale of the target
    private float initialScale;

    // The current scale of the target
    private float currentScale;

    // The initial distance from the camera to the target
    private float initialDistance;

    void Start()
    {
        // Save the initial scale and distance
        initialScale = target.localScale.x;
        initialDistance = distance;
    }

    void LateUpdate()
    {
        // Calculate the current scale of the target
        currentScale = target.localScale.x;

        // Adjust the distance to the target based on the change in scale

        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position - (target.forward * distance);
        desiredPosition.y = height;

        // Set the position of the camera using smooth damping
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);

        // Look at the target
        transform.LookAt(target);
    }
}

