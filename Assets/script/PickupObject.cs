using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public float pullSpeed = 5f;
    public float pickupRange = 3f;
    public Transform holdPosition;
    private GameObject Pickup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            Pickup = other.gameObject;
            Pickup.GetComponent<Rigidbody>().isKinematic = true;
            // You can add other actions here (like disabling the collider or other effects)
        }
    }

    void Update()
    {
        if (Pickup != null)
        {
            Pull();
        }
    }

    void Pull()
    {
        if (Pickup != null && holdPosition != null)
        {
            Pickup.transform.position = Vector3.MoveTowards(Pickup.transform.position, holdPosition.position, pullSpeed * Time.deltaTime);

            // When close to the holdPosition, snap it in place
            if (Vector3.Distance(Pickup.transform.position, holdPosition.position) < 0.1f)
            {
                Pickup.transform.position = holdPosition.position;
                // Optionally, destroy the pickup after reaching the holdPosition
                // Destroy(Pickup);
            }
        }
    }
}
