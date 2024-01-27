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
    
    private void Start()
    {
        //firstclipPlaying = false;
        audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        audioSource.Stop();
        Instantiate(stillcabinet_Prefab, gameObject.transform.position, quaternion.identity);
        Destroy(gameObject);
    }

    private void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = loopingClip;
            audioSource.Play();
            audioSource.loop = true;

        }
    }


    public bool ReInteract()
    {
        return false;
    }
}
