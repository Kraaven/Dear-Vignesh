using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberryPick : MonoBehaviour,IInteractableObject
{
    public bool SBpickedup = false;
    private bool holdingObj = false;
    [SerializeField] private GameObject strawberry, anchor;
    
    public void Interact()
    {
        if (!SBpickedup && !holdingObj)
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
        holdingObj = true;
        strawberry.transform.SetParent(anchor.transform);
        strawberry.transform.position = anchor.transform.position;
        strawberry.GetComponent<Rigidbody>().isKinematic = true;
        strawberry.GetComponent<BoxCollider>().enabled = false;
    }

    void PutDownStrawberry()
    {
        SBpickedup = false;
        holdingObj = false;

    }

    public bool ReInteract()
    {
        return false;
    }
}
