using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class cabinet_vanishScript : MonoBehaviour, IInteractableObject
{

    [SerializeField] private GameObject vanishCabinet;
    [SerializeField] private BoxCollider vanishcabinet_Collider;
    [SerializeField] private GameObject stillcabinet_Prefab;

    public TextController dialougue;
    public void Interact()
    {
        //Instantiate(stillcabinet_Prefab, gameObject.transform.position, quaternion.identity);
        //Destroy(gameObject);

    }

    private void Start()
    {
        vanishcabinet_Collider.enabled = false;
        StartCoroutine(VanishCabinet());  
    }

    IEnumerator VanishCabinet()
    {
        for (int i = 0; i < 120; i++)
        {
            vanishCabinet.transform.Translate(0,0,-0.1f);
            yield return new WaitForSeconds(0.05f);
        }
        
        //dialougue.DisplayThought("Damn, that vanished....weird",0);
    }

    public bool ReInteract()
    {
        return false;
    }
}
