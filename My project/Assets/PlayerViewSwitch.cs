using UnityEngine;

public class PlayerViewSwitch : MonoBehaviour
{
    // Declare variables to hold references to the view points
    private Transform externalViewPoint;
    private Transform internalViewPoint;

    // Button for switching (can be configured in the Input Manager)
    public string toggleKey = "space";

    private bool isExternal = false;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObjects by name in the scene
        externalViewPoint = GameObject.Find("ExternalViewPoint")?.transform;
        internalViewPoint = GameObject.Find("InternalViewPoint")?.transform;

        // Check if both view points were found
        if (externalViewPoint == null)
        {
            Debug.LogError("ExternalViewPoint not found in the scene!");
        }
        if (internalViewPoint == null)
        {
            Debug.LogError("InternalViewPoint not found in the scene!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the button is pressed
        if (Input.GetKeyDown(toggleKey))
        {
            SwitchViewPoint();
        }
    }

    // Switch between the internal and external view points
    void SwitchViewPoint()
    {
        // Check if both view points are assigned
        if (externalViewPoint != null && internalViewPoint != null)
        {
            if (isExternal)
            {
                // Switch to the internal (room) view point
                transform.position = internalViewPoint.position;
                transform.rotation = internalViewPoint.rotation;
            }
            else
            {
                // Switch to the external view point
                transform.position = externalViewPoint.position;
                transform.rotation = externalViewPoint.rotation;
            }

            // Toggle the view state
            isExternal = !isExternal;
        }
        else
        {
            Debug.LogError("One or both view points are not assigned!");
        }
    }
}
