using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public bool isSelected = false;
    public GameObject selectionRingPrefab; // Reference to the selection ring prefab

    private GameObject selectionRing; // The instantiated selection ring object

    private void Start()
    {
        // Instantiate the selection ring and make it inactive initially
        selectionRing = Instantiate(selectionRingPrefab, transform.position, Quaternion.identity);
        selectionRing.SetActive(false);
    }

    private void OnMouseDown()
    {
        ToggleSelection();

        // Add any other logic you want to execute when the character is selected/deselected
    }

    private void ToggleSelection()
    {
        isSelected = !isSelected;
        UpdateSelectionVisual();
    }

    private void UpdateSelectionVisual()
    {
        // Activate/deactivate the selection ring based on the selection status
        selectionRing.SetActive(isSelected);
    }
}
