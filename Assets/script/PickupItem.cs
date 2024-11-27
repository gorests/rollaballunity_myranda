using UnityEngine;
using TMPro;  // Required for TextMeshPro

public class PickupItem : MonoBehaviour
{
    public TMP_Text itemCountText;  // Reference to the TextMeshPro Text UI element
    private int itemCount = 0;  // Variable to store the item count

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            itemCount++;
            UpdateItemCountText();
        }
    }

    private void UpdateItemCountText()
    {
        itemCountText.text = "Items Collected: " + itemCount.ToString();
    }
}
