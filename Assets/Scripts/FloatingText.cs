using UnityEngine;
using TMPro;

public class FloatingText : MonoBehaviour
{
    [Header("Hover Settings")]
    [SerializeField] private float hoverSpeed = 2f; // Speed of the hover motion
    [SerializeField] private float hoverAmplitude = 0.5f; // Amplitude of the hover motion

    [Header("Spin Settings")]
    [SerializeField] private float spinSpeed = 50f; // Speed of rotation (degrees per second)

    [Header("Text Settings")]
    [SerializeField] private string message = "Push the button to restart";

    private TextMeshPro textMeshPro;
    private int fallCounter = 0;

    private Vector3 startPosition;

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        // Store the initial position of the text
        startPosition = transform.position;
        textMeshPro.text = message;
    }

    private void Update()
    {
        // Hover effect: Move the text up and down in a sinusoidal pattern
        float hoverOffset = Mathf.Sin(Time.time * hoverSpeed) * hoverAmplitude;
        transform.position = startPosition + new Vector3(0, hoverOffset, 0);

        // Spin effect: Rotate the text around its Y-axis
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime, Space.World);

        if (fallCounter > 0)
        {
            embedFallCounter();
        }
    }

    public void incrementFallCounter()
    {
        fallCounter++;
    }

    public void embedFallCounter()
    {
        textMeshPro.text = "Fall Counter: " + fallCounter + "\n" + message;
    }
}
