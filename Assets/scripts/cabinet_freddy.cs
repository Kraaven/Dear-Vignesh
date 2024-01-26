using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinet_freddy : MonoBehaviour, IInteractableObject
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource loopingAudioSource;
    private bool firstclipPlaying;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        loopingAudioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        audioSource.Play(0);
    }

    private void Update()
    {
        if (!audioSource.isPlaying && !loopingAudioSource)
        {
            
        }
    }


    public bool ReInteract()
    {
        return false;
    }
}
