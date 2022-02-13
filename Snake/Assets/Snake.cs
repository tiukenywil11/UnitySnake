using UnityEngine;

public class Snake : MonoBehaviour
{
    // Vector2: vector with x and y axis
    // Default will move to the right
    private Vector2 _direction = Vector2.right;

    // Update(): Unity will automatically call for every single frame this object is active   
    private void Update() {

        if (Input.GetKeyDown(KeyCode.W)) {
            _direction = Vector2.up;
        } else if (Input.GetKeyDown(KeyCode.S)) {
            _direction = Vector2.down;
        } else if (Input.GetKeyDown(KeyCode.A)) {
            _direction = Vector2.left;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            _direction = Vector2.right;
        }

    }

    // FixedUpdate(): Always ran at a fixed time interval
    private void FixedUpdate() {
        
        // Position is always a Vector3: vector with x, y, and z axis
        this.transform.position = new Vector3(
            // Mathf.Round: makes the object have a whole number, so the snake will be aligned to a grid
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );

    }
}
