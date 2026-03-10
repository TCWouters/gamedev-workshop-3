using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public static int keyCount = 0;
    public Collider doorCollider;

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            keyCount++;
            Debug.Log("Key picked up! Total keys: " + keyCount);
            
            // If 3 keys are collected, disable the door collider
            if (keyCount >= 3 && doorCollider != null)
            {
                doorCollider.enabled = false;
                Debug.Log("Door unlocked!");
            }
            
            Destroy(gameObject);
        }
    }
}
