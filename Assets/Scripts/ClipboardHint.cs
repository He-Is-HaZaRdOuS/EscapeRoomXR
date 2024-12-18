using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClipboardHint : MonoBehaviour
{
    [SerializeField] private TextMeshPro textMeshPro; // Reference to the TextMeshPro component
    [SerializeField] private string hintText = "I'm a magical clipboard\nTake me with you to help you escape!"; // Default hint text

    private void Start()
    {
        // Set the default text when the game starts
        if (textMeshPro != null)
        {
            textMeshPro.text = hintText;
        }
    }

    // Method to update the text dynamically
    public void UpdateHint(string newHint)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = newHint;
        }
    }
}
