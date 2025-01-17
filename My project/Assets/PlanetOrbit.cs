using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public float rotationSpeed = 10f; // You can change this in the Inspector to control speed

    void Update()
    {
        // Rotate the planet around its Y-axis (vertical axis) each frame
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

