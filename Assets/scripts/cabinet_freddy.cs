using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinet_freddy : MonoBehaviour, IInteractableObject
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip firstClip;
    [SerializeField] private AudioClip loopingClip;
    private bool firstclipPlaying;
    
    private void Start()
    {
        firstclipPlaying = false;
        audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        audioSource.PlayOneShot(firstClip);
        firstclipPlaying = true;
    }

    private void Update()
    {
        if (firstclipPlaying && !audioSource.isPlaying)
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
