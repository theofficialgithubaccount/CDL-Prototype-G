using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sit : MonoBehaviour
{
    private float originalY;   // Store the original y position of the object
    private bool isLowered;    // Keep track of whether the object is currently lowered

    void Start()
    {
        originalY = transform.position.y;
        isLowered = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!isLowered)
            {
                transform.position -= new Vector3(0, 0.44f, 0);  // Lower the object by 1.34 meters
                isLowered = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            if (isLowered)
            {
                transform.position = new Vector3(transform.position.x, originalY, transform.position.z);  // Return the object to its original y position
                isLowered = false;
            }
        }
    }
}


