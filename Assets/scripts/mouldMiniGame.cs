using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mouldMiniGame : MonoBehaviour,IInteractableObject
{
    public bool isMoulding = false;
    [SerializeField] private GameObject anchor;
    private GameObject holdingObj;
    [SerializeField] List<GameObject> ingredients;
    public void Interact()
    {
        if (!isMoulding)
        {
            startMoulding();
            isMoulding = false;
            
        }
    }

    void startMoulding()
    {
        Debug.Log("Is Working");
        isMoulding = true;
        Destroy(anchor.transform.GetChild(0).gameObject);
        
    }

    private void Update()
    {
    }


    public bool ReInteract()
    {
        return false;
    }
}
