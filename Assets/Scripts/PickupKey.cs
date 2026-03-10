using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public static int keyCount = 0;

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            keyCount++;
            Debug.Log("Key picked up! Total keys: " + keyCount);
            Destroy(gameObject);
        }
    }
}
