using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class switchCabinet : MonoBehaviour, IInteractableObject
{
    [SerializeField] private GameObject[] cabinetPrefabs;
    [SerializeField] private GameObject stillcabinet_Prefab;
    [SerializeField] private PlayerData dataPlayer;
    public int interactionOrder = 0;
    
    private void Start()
    {
        dataPlayer.interactionCount = 1;
    }

    public void Interact()
    {
        Debug.Log(dataPlayer.interactionCount);
        switch (dataPlayer.interactionCount)
        {
            case 1:
                Instantiate(cabinetPrefabs[0], stillcabinet_Prefab.transform.position, quaternion.identity);
                gameObject.SetActive(false);
                break;
            case 2:
                Instantiate(cabinetPrefabs[1], stillcabinet_Prefab.transform.position, quaternion.identity);
                Destroy(gameObject);
                break;
            case 3:
                Instantiate(cabinetPrefabs[2], stillcabinet_Prefab.transform.position, quaternion.identity);
                Destroy(gameObject);
                break;
            case 4:
                break;
        }

        dataPlayer.interactionCount++;
    }

    private void Update()
    {
    }

    public bool ReInteract()
    {
        return false;
    }
}
