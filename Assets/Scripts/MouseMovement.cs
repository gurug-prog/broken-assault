using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity = 500f;

    private float xRotation = 0f;
    private float yRotation = 0f;

    [SerializeField]
    private float topClampDegrees = -90f;

    [SerializeField]
    private float bottomClampDegrees = 90f;

    // Start is called before the first frame update
    void Start()
    {
        // Locking the cursor cause we don't need it in an FPS game
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // X rotation (Look up and down)
        xRotation -= mouseY;

        // Clamp the rotation
        xRotation = Mathf.Clamp(xRotation, topClampDegrees, bottomClampDegrees);

        // Y rotation (Look left and right)
        yRotation += mouseX;

        // Apply rotation
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
