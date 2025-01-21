using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LightController : MonoBehaviour
{
    // Declare a public variable to hold a reference to the Light component
    public Light lightComponent;

    // Reference to the XR Controller
    public XRController rightController;

    // Define the action button
    private InputDevice rightControllerDevice;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject by name
        GameObject pointLight = GameObject.Find("Point Light");

        // If the GameObject is found, get the Light component
        if (pointLight != null)
        {
            lightComponent = pointLight.GetComponent<Light>();
        }
        else
        {
            Debug.LogError("Point Light GameObject not found!");
        }

        // Optional: check if the Light component was successfully found
        if (lightComponent == null)
        {
            Debug.LogError("Light component not found on Point Light GameObject!");
        }

        // Get the XR device for the Right Controller
        rightControllerDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the right controller is available
        if (rightControllerDevice.isValid)
        {
            // Check if the A button is pressed on the Right Controller
            bool buttonPressed = false;
            rightControllerDevice.TryGetFeatureValue(CommonUsages.primaryButton, out buttonPressed);

            if (buttonPressed)
            {
                // Change light color to red when the A button is pressed
                if (lightComponent != null)
                {
                    lightComponent.color = new Color(1f, 0f, 0f); // Red color
                }
            }
        }
    }
}
