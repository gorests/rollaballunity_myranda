using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    // This function is called when the trigger collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has the "PickUp" tag
        if (other.CompareTag("Player"))
        {
            // Print a message to confirm the trigger event
            Debug.Log("Object triggered with PickUp and will be destroyed.");

            // Destroy the object this script is attached to
            Destroy(gameObject);
        }
    }
}
