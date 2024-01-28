using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ChickenInteract : MonoBehaviour, IInteractableObject
{
    public GameObject player;
    public GameObject cameraObj;
    public GameObject fatherFigure;
    public bool isPickedUp = false;
    public CharacterMovement characterMovement;
    public CameraController cameraController;
    public float rotationSmoothing = 0.1f;
    private bool held;
    public int eggs = 0;
    private float chickenSpeed = 10f;
    public AudioSource gsb;
    public AudioSource killChicken;
    public GameObject boundaries;
    public bool isShot = false;
    public void Interact()
    {
        Debug.Log("Interacting with chicken");
        if (!held)
        {
            Debug.Log("Holding chicken");
            gameObject.GetComponent<Collider>().enabled = false;
            isPickedUp = true;
            held = true;
        }
        else
        {
            Debug.Log("Interact with 2nd time?");
            if (eggs >= 3)
            {
                Destroy(boundaries);
                Debug.Log("We have 3 eggs");
                
                Debug.Log("launching");
                isPickedUp = false; 
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().AddForce(transform.forward * chickenSpeed, ForceMode.Impulse);
                gameObject.transform.parent = fatherFigure.transform;
                Invoke("PlayAudioWithDelay", 0.2f);
                Destroy(gameObject,1.5f);
                Debug.Log("Audio play INvoke");
                Invoke("PlayAudioWithDelayKillChicken", 0.2f);
                characterMovement.speed = 4.5f;
                //cameraController.sensitivity = 5;
                isShot = true;
            } 
        }
    }

    private void PlayAudioWithDelay()
    {
        gsb.Play();
    }

    private void PlayAudioWithDelayKillChicken()
    {
        killChicken.Play(); 
    }

    public bool ReInteract()
    {
        if (isShot = true)
        {
            return false;
        }
        return true;
    }

    private void pickedUp()
    {
        if (isPickedUp)
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.transform.parent = cameraObj.transform;
            characterMovement.speed = 0;
            //cameraController.sensitivity = 0.5f;

            // Store the original rotation of the camera
            Quaternion originalRotation = cameraObj.transform.rotation;

            // Rotate the camera using the mouse input
            ///cameraController.mouseLook.y += Input.GetAxis("Mouse Y") * cameraController.sensitivity;
            //cameraController.mouseLook.x += Input.GetAxis("Mouse X") * cameraController.sensitivity;

            // Clamp the x-axis rotation to restrict it
            //cameraController.mouseLook.x = Mathf.Clamp(cameraController.mouseLook.x, -30f, 30f); // Adjust the values as needed
            //cameraController.mouseLook.y = Mathf.Clamp(cameraController.mouseLook.y, -25f, 0f);

            // Calculate the target rotation
            //Quaternion targetRotation = Quaternion.Euler(-cameraController.mouseLook.y, cameraController.mouseLook.x, 0);

            // Apply smoothing to the rotation
            float smoothFactor = rotationSmoothing * Time.deltaTime;
            //cameraObj.transform.rotation = Quaternion.Slerp(cameraObj.transform.rotation, targetRotation, smoothFactor);

            // Restore the original rotation in the z-axis (roll)
            cameraObj.transform.rotation = Quaternion.Euler(cameraObj.transform.rotation.eulerAngles.x, cameraObj.transform.rotation.eulerAngles.y, originalRotation.eulerAngles.z);
        }
    }

    // Start is called before the first frame update
        void Start()
        {
            gsb = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            pickedUp();
        }
}
