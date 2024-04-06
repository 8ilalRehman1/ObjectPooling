using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left click to move
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object is a selectable character
                Selectable selectableCharacter = hit.collider.GetComponent<Selectable>();

                if (selectableCharacter != null && selectableCharacter.isSelected)
                {
                    // Handle left-click movement logic (e.g., move the character to the clicked position).
                    // For simplicity, you can just log a message for now.
                    Debug.Log("Move command for selected character: " + hit.point);
                }
            }
        }
        else if (Input.GetMouseButtonDown(1)) // Right click to attack
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object is a selectable character
                Selectable selectableCharacter = hit.collider.GetComponent<Selectable>();

                if (selectableCharacter != null && selectableCharacter.isSelected)
                {
                    // Handle right-click attack logic.
                    // For simplicity, you can just log a message for now.
                    Debug.Log("Attack command for selected character: " + hit.collider.gameObject.name);
                }
            }
        }
    }
}
