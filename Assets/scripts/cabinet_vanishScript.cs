using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinet_vanishScript : MonoBehaviour, IInteractableObject
{

    [SerializeField] private GameObject vanishCabinet;
    [SerializeField] private BoxCollider vanishcabinet_Collider;
    public void Interact()
    {
        vanishcabinet_Collider.enabled = false;
        StartCoroutine(VanishCabinet());
    }

    IEnumerator VanishCabinet()
    {
        for (int i = 0; i < 120; i++)
        {
            vanishCabinet.transform.Translate(0,0,0.1f);
            yield return new WaitForSeconds(0.05f);
        }
        
        
    }

    public bool ReInteract()
    {
        return false;
    }
}
