using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float minX = -5f;  // Minimum x-coordinate of the perimeter
    public float maxX = 5f;   // Maximum x-coordinate of the perimeter
    public float minY = -5f;  // Minimum y-coordinate of the perimeter
    public float maxY = 5f;   // Maximum y-coordinate of the perimeter

    void Update()
    {
        // Get input from arrow keys or WASD
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed * Time.deltaTime;

        // Update object position within the perimeter
        Vector3 newPosition = transform.position + new Vector3(movement.x, movement.y, 0f);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Move the object
        transform.position = newPosition;
    }
}