using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float yOffset = 0.01f; // Offset to prevent z-fighting with the character model

    void Update()
    {
        // Rotate the selection ring to face the camera
        transform.LookAt(Camera.main.transform);

        // Adjust the position to avoid z-fighting
        transform.position = new Vector3(transform.parent.position.x, transform.parent.position.y + yOffset, transform.parent.position.z);
    }
}
