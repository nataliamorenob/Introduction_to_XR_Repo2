using UnityEngine;

public class LightController : MonoBehaviour
{
    // Declare a public variable to hold a reference to the Light component
    public Light lightComponent;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Light component attached to this GameObject
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // You can add logic here to modify the light, if needed
    }
}
