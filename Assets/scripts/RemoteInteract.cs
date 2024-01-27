using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RemoteInteract : MonoBehaviour,IInteractableObject
{
    public GameObject anchor;
    public GameObject Player;
    private bool Pickup;

    public GameObject video;
    public GameObject image;
    
    public void Interact()
    {
        if (!Pickup)
        {
            Pickup = true;
            gameObject.transform.SetParent(anchor.transform);
            gameObject.transform.position = anchor.transform.position;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<BoxCollider>().enabled = false; 
        }
        else
        {
            Debug.Log("Change Channel");
            video.SetActive(false);
            image.SetActive(true);
            
            transform.Translate(-0.7f,1,0);
            Player.GetComponent<CharacterMovement>().enabled = true;
            Player.GetComponent<Collider>().enabled = true;
            Player.GetComponent<Rigidbody>().useGravity = true;
            Destroy(Player.GetComponent<PlayerSit>());
            Player.GetComponent<InteractionController>().LastInteracted = null;
            Destroy(gameObject);
            
        }
        
    }

    public bool ReInteract()
    {
        return true;
    }

}
