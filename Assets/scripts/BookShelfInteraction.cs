using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelfInteraction : MonoBehaviour, IInteractableObject
{
    public GameObject hands;
    public TextController ThoughtUI;
    public void Interact()
    {
        Vector3 newpos = new Vector3(transform.position.x, transform.position.y, transform.position.z -1);
       GameObject hand =  Instantiate(hands,newpos,Quaternion.identity);
       ThoughtUI.DisplayThought("Damn, thats cool",1.2f);
    }

    public bool ReInteract()
    {
        return false;
    }
}
