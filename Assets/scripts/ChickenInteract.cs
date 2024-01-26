using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChickenInteract : MonoBehaviour , IInteractableObject
{
    public GameObject player;
    public bool isPickedUp = false;
    public CharacterMovement characterMovement;
    public CameraController cameraController;
    public void Interact()
    {
        gameObject.transform.parent = player.transform;
        gameObject.transform.position = new Vector3(player.transform.position.x, 3.0f, player.transform.position.z + 1);
        gameObject.GetComponent<Collider>().enabled = false;
        isPickedUp = true;
    }
    public bool ReInteract()
    {
        return false;
    }

    private void pickedUp()
    {
        if (isPickedUp == true)
        {
            characterMovement.speed = 0;
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
