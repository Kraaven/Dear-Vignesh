using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MilkCartonInteraction : MonoBehaviour, IInteractableObject
{
    public void Interact()
    {
        Destroy(gameObject);
    }
    public bool ReInteract()
    {
        return false;
    }
}
