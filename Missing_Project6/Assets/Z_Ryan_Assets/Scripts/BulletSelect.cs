using UnityEngine;

public class BulletSelect : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float destroyDelay = 0.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullet();
        }
    }

    void SpawnBullet()
    {
        // Instantiate the bullet at the current position with no initial velocity
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // Add a collider to the bullet (assuming it doesn't have one already)
        Collider2D bulletCollider = bullet.GetComponent<Collider2D>();
        if (!bulletCollider)
        {
            bulletCollider = bullet.AddComponent<BoxCollider2D>();
        }

        // Subscribe to the collision event
        bulletCollider.isTrigger = true;

        // Add the BulletCollisionHandler component and set its properties
        BulletCollisionHandler2D collisionHandler = bullet.GetComponent<BulletCollisionHandler2D>();
        if (collisionHandler == null)
        {
            collisionHandler = bullet.AddComponent<BulletCollisionHandler2D>();
        }

        collisionHandler.allowedTag = "Event"; // Set your desired tag

        // Destroy the bullet after a short delay
        Destroy(bullet, destroyDelay);
        //Debug.Log("It Pressed!!");
    }
}