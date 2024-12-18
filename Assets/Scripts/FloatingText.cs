using UnityEngine;

public class FloatingText : MonoBehaviour
{
    [Header("Hover Settings")]
    [SerializeField] private float hoverSpeed = 2f; // Speed of the hover motion
    [SerializeField] private float hoverAmplitude = 0.5f; // Amplitude of the hover motion

    [Header("Spin Settings")]
    [SerializeField] private float spinSpeed = 50f; // Speed of rotation (degrees per second)

    private Vector3 startPosition;

    private void Start()
    {
        // Store the initial position of the text
        startPosition = transform.position;
    }

    private void Update()
    {
        // Hover effect: Move the text up and down in a sinusoidal pattern
        float hoverOffset = Mathf.Sin(Time.time * hoverSpeed) * hoverAmplitude;
        transform.position = startPosition + new Vector3(0, hoverOffset, 0);

        // Spin effect: Rotate the text around its Y-axis
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime, Space.World);
    }
}
