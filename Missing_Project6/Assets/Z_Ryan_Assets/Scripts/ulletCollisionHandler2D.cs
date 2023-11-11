using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler2D : MonoBehaviour
{
    public string allowedTag = "Event"; // Set a default or appropriate tag

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object has a specific tag or layer if needed
        if (other.CompareTag("Event"))
        {
            // Your logic here
            Debug.Log("It Hit!!!");
            Destroy(gameObject);
        }
    }
}