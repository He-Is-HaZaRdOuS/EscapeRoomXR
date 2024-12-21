using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWindow : MonoBehaviour
{

    [Header("Spin Settings")]
    [SerializeField] private float spinSpeed = 50f; // Speed of rotation (degrees per second)
    private Vector3 startPosition;

    private void Start()
    {
        // Store the initial position of the window
        startPosition = transform.position;
    }

    private void Update()
    {
        // Spin effect: Rotate the window around its Y-axis
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime, Space.World);

    }
}
