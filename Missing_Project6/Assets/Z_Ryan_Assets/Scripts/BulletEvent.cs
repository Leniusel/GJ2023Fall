using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEvent : MonoBehaviour
{

}
public class BulletCollisionHandler2D : MonoBehaviour
{
    public string allowedTag = "DefaultTag"; // Set a default or appropriate tag

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object exists and has the allowed tag
        if (other != null && other.CompareTag(allowedTag))
        {
            // Destroy the bullet when it collides with an object having the allowed tag
            Destroy(gameObject);
        }
    }
}
