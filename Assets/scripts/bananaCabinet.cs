using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class bananaCabinet : MonoBehaviour,IInteractableObject
{
    private bool isOpen_bananaCabinet;
    // Start is called before the first frame update
    void Start()
    {
        isOpen_bananaCabinet = true;
    }

    public void Interact()
    {
        if (!isOpen_bananaCabinet)
        {
            OpenCabinet_Banana();
        }
        else
        {
            CloseCabinet_Banana();
        }
    }

    void OpenCabinet_Banana()
    {
        isOpen_bananaCabinet = true;
        Debug.Log("Is Open");
    }

    void CloseCabinet_Banana()
    {
        isOpen_bananaCabinet = false;
        Debug.Log("Is Close");
    }

    public bool ReInteract()
    {
        return false;
    }
}
