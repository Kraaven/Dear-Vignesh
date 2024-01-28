using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs_Layer : MonoBehaviour,IInteractableObject
{
    public GameObject mould;
    public void Interact()
    {
        gameObject.SetActive(false);
        mould.transform.GetChild(1).gameObject.SetActive(true);
    }

    public bool ReInteract()
    {
        return false;
    }
}