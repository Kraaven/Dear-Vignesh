using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberryPick : MonoBehaviour,IInteractableObject
{
    private bool SBpickedup = false;
    [SerializeField] private GameObject strawberry, anchor;
    
    public void Interact()
    {
        if (!SBpickedup)
        {
            PickUpStrawberry();
        }
        else
        {
            PutDownStrawberry();
        }
    }

    void PickUpStrawberry()
    {
        SBpickedup = true;
        strawberry.transform.SetParent(anchor.transform);
        strawberry.transform.position = anchor.transform.position;
        strawberry.GetComponent<Rigidbody>().isKinematic = true;
        strawberry.GetComponent<BoxCollider>().enabled = false;
    }

    void PutDownStrawberry()
    {
        
    }

    public bool ReInteract()
    {
        return false;
    }
}
