using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 2.0f;
    float cameraVerticalRotation = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Locks the cursor to the center and hides it    
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        // Collects the mouse input
        float inputX = Input.GetAxis("Mouse X")*mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y")*mouseSensitivity;

        // Rotates the camera around its localx axis and locks it at 90 and -90
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90.0f, 90.0f);
        transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

        // Rotate the player object and the camera around its Y axis

        player.Rotate(Vector3.up * inputX);


    }
}
