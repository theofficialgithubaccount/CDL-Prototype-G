using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float zoomSpeed = 100f;

    void Update()
    {
        // Move the camera using arrow keys
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Zoom in/out using mouse scroll wheel
        float zoomAmount = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
        transform.position += transform.forward * zoomAmount;

        // Rotate the camera using right mouse button
        if (Input.GetMouseButton(1))
        {
            float rotationX = Input.GetAxis("Mouse X");
            float rotationY = Input.GetAxis("Mouse Y");

            transform.Rotate(Vector3.up, rotationX);
            transform.Rotate(Vector3.right, -rotationY);
        }
    }
}

