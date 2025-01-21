using UnityEngine;

public class PlayerViewSwitch : MonoBehaviour
{
    // External view point (outside the room)
    public Transform externalViewPoint;
    // Internal view point (inside the room --> player starts)
    public Transform internalViewPoint;

    // Button for switching (can be configured in the Input Manager)
    public string toggleKey = "space";

    private bool isExternal = false;

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
}

