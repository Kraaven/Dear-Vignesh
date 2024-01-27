using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject Player;

    public void Start()
    {
        Player.GetComponent<CharacterMovement>().enabled = false;
        Camera.main.GetComponent<CameraController>().enabled = false;
        Camera.main.GetComponent<InteractionController>().enabled = false;
        
    }

    public void Startgame()
    {
        Debug.Log("Starting Game");
        Player.GetComponent<CharacterMovement>().enabled = true;
        Camera.main.GetComponent<CameraController>().enabled = true;
        Camera.main.GetComponent<InteractionController>().enabled = true;
        gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
