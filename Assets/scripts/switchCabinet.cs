using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class switchCabinet : MonoBehaviour, IInteractableObject
{
    [SerializeField] private GameObject[] cabinetPrefabs;
    [SerializeField] private GameObject stillcabinet_Prefab;
    private int interactionCount = 1;
    private void Start()
    {
        
    }

    public void Interact()
    {
        switch (interactionCount)
        {
            case 1:
                Instantiate(cabinetPrefabs[0], stillcabinet_Prefab.transform.position, quaternion.identity);
                Destroy(gameObject);
                break;
            case 2:
                Instantiate(cabinetPrefabs[1], stillcabinet_Prefab.transform.position, quaternion.identity);
                break;
            case 3:
                Instantiate(cabinetPrefabs[2], stillcabinet_Prefab.transform.position, quaternion.identity);
                break;
        }
    }

    private void Update()
    {
        
    }

    public bool ReInteract()
    {
        return false;
    }
}
