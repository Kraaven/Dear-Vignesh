using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChickenInteract : MonoBehaviour, IInteractableObject
{
    public GameObject player;
    public GameObject camera;
    public float currentRotationX;
    public bool isPickedUp = false;
    public CharacterMovement characterMovement;
    public CameraController cameraController;
    public float rotationSmoothing = 0.1f;

    public void Interact()
    {
        // gameObject.transform.parent = player.transform;
        // gameObject.transform.position = new Vector3(player.transform.position.x, 3.0f, player.transform.position.z + 1);
        gameObject.GetComponent<Collider>().enabled = false;
        isPickedUp = true;
    }

    public bool ReInteract()
    {
        return false;
    }

    private void pickedUp()
    {
        if (isPickedUp)
        {
            // characterMovement.speed = 0;
            // cameraController.mouseLook.x = Mathf.Clamp(cameraController.mouseLook.x, -0.01f,0.01f );
            // currentRotation = gameObject.transform.position;
            // gameObject.transform.position = new Vector3(camera.transform.position.x, 3.0f, camera.transform.position.z + 1);
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.transform.parent = camera.transform;
            characterMovement.speed = 0;
            cameraController.sensitivity = 0.5f;

            // Store the original rotation of the camera
            Quaternion originalRotation = camera.transform.rotation;

            // Rotate the camera using the mouse input
            cameraController.mouseLook.y += Input.GetAxis("Mouse Y") * cameraController.sensitivity;
            cameraController.mouseLook.x += Input.GetAxis("Mouse X") * cameraController.sensitivity;

            // Clamp the x-axis rotation to restrict it
            cameraController.mouseLook.x = Mathf.Clamp(cameraController.mouseLook.x, -30f, 30f); // Adjust the values as needed
            cameraController.mouseLook.y = Mathf.Clamp(cameraController.mouseLook.y, -25f, 0f);

            // Calculate the target rotation
            Quaternion targetRotation = Quaternion.Euler(-cameraController.mouseLook.y, cameraController.mouseLook.x, 0);

            // Apply smoothing to the rotation
            float smoothFactor = rotationSmoothing * Time.deltaTime;
            camera.transform.rotation = Quaternion.Slerp(camera.transform.rotation, targetRotation, smoothFactor);

            // Restore the original rotation in the z-axis (roll)
            camera.transform.rotation = Quaternion.Euler(camera.transform.rotation.eulerAngles.x, camera.transform.rotation.eulerAngles.y, originalRotation.eulerAngles.z);
        }
    }

    // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            pickedUp();
        }
}
