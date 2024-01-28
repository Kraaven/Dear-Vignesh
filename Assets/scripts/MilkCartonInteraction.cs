using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkCartonInteraction : MonoBehaviour, IInteractableObject
{
    // Start is called before the first frame update

    public bool edabayah = false;

    public void Start()
    {
        StartCoroutine(resetEdabaya());
    }

    public void Interact()
    {
        edabayah = true;
    }

    public bool interacted()
    {
        if (edabayah)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool ReInteract()
    {
        return false;
    }

    IEnumerator resetEdabaya()
    {
        while (edabayah == true)
        {
            yield return new WaitForSeconds(1);
            edabayah = false;
        }
    }
}
