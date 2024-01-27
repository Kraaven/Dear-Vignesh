using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteInteract : MonoBehaviour,IInteractableObject
{
    public GameObject anchor;
    private bool Pickup;
    
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
        }
        
    }

    public bool ReInteract()
    {
        return true;
    }

}
