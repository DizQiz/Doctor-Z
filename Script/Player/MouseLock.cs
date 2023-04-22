using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    [SerializeField] private float sensitivity = 1f;
    private float pitch = 0f;
    private float yaw = 0f;

    void Start()
    {
        // Lock the cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Initialize the camera rotation to the current rotation
        pitch = transform.eulerAngles.x;
        yaw = transform.eulerAngles.y;
    }

    void Update()
    {
        // Rotate the camera based on mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        yaw += mouseX;
        pitch -= mouseY;

        // Clamp the pitch angle to prevent flipping
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        // Rotate the camera based on the new pitch and yaw angles
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

        // Move the cursor to the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
