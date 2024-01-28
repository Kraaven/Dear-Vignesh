using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class cabinet_freddy : MonoBehaviour, IInteractableObject
{
    [SerializeField] private AudioSource audioSource;
    //[SerializeField] private AudioClip firstClip;
    [SerializeField] private AudioClip loopingClip;
    //private bool firstclipPlaying;
    [SerializeField] private GameObject stillcabinet_Prefab;
    private bool isOpen;
    
    private void Start()
    {
        //firstclipPlaying = false;
        audioSource = GetComponent<AudioSource>();
        isOpen = true;
    }
    
    public void Interact()
    {
        if (!isOpen)
        {
            OpenCabinet_Freddy();
        }
        else
        {
            CloseCabinet_Freddy();
        }

    }
    

    void OpenCabinet_Freddy()
    {
        isOpen = true;
        Debug.Log("Freddy is Open");
        gameObject.transform.Rotate(0,-90f,0);
        //audioSource.Stop();

    }

    void CloseCabinet_Freddy()
    {
        isOpen = false;
        Debug.Log("Freddy is Close");
        gameObject.transform.Rotate(0,0,0);
        audioSource.Pause();
    }

    private void Update()
    {
        if (!audioSource.isPlaying && isOpen)
        {
            audioSource.clip = loopingClip;
            audioSource.Play();
            audioSource.loop = true;
        }

        gameObject.transform.position = stillcabinet_Prefab.transform.position;

    }

    public bool ReInteract()
    {
        return false;
    }
}
