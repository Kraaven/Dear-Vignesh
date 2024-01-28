using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FlushingTheFlush : MonoBehaviour,IInteractableObject
{
    //Declarations
    public bool neverSeenATrain = true;
    public GameObject Train;
    public GameObject ui;
    public GameObject player;
    public GameObject door;
    public GameObject wallToTrain;
    public GameObject milkScreen;
    public GameObject transactionScreen;
    public GameObject laptop;
    private bool canOderMilk = false;
    private bool milkscreenIsOn = false;
    public TextController thought;
    private bool sequencecomplete = false;
    public GameObject keyboard;
    public ParticleSystem particleSystem;
    public GameObject milk;
    public MilkCartonInteraction milkCartonInteraction;

    public void Start()
    {
        particleSystem.Stop(); 
    }

    public void Interact()
    {
        if (!neverSeenATrain && canOderMilk)
        {
            particleSystem.GetComponent<ParticleSystem>().Play();
            laptop.GetComponent<AudioSource>().Play();
            StartCoroutine(rotateTheKeyboard(keyboard));
            if (milkscreenIsOn && !sequencecomplete)
            {
                milkScreen.SetActive(false);
                transactionScreen.SetActive(true);
                sequencecomplete = true;
                StartCoroutine(moveUpTheMilk(milk));
            }
            if (!milkscreenIsOn && !sequencecomplete)
            {
                milkScreen.SetActive(true);
                milkscreenIsOn = true;
            }
        }

        if (neverSeenATrain)
        {
            neverSeenATrain = false;
            Vector3 pos = new Vector3(transform.position.x + 30, transform.position.y, transform.position.z - 2.15f);
            GameObject train = Instantiate(Train, pos, Quaternion.identity); // spawn train
            door.SetActive(true);
            wallToTrain.SetActive(false);
            StartCoroutine(moveTrain(train, train.GetComponent<AudioSource>())); // Train animation
        }
    }

    public void openEyes()
    {
        ui.SetActive(false);
    }
    public bool ReInteract()
    {
        if (sequencecomplete)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    IEnumerator moveTrain(GameObject T, AudioSource A)
    {
        A.Play();
        yield return new WaitForSeconds(14);
        for (int i = 0; i < 300; i++)
        {
            T.transform.Translate(-0.1f, 0, 0);
            yield return new WaitForSeconds(Time.deltaTime);
        }
        ui.SetActive(true);
        player.transform.position = new Vector3(0f, 1.85f, 0f);
        Invoke("openEyes", 3);
        yield return new WaitForSeconds(3);
        Destroy(T);
        wallToTrain.SetActive(true);
        door.SetActive(false); 
        canOderMilk = true;
    }

    IEnumerator rotateTheKeyboard(GameObject K)
    {
        while (true)
        {
            K.transform.Rotate(0f, 15f, 0f, Space.Self);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }

    IEnumerator moveUpTheMilk(GameObject M)
    {
        for (int i = 0; i < 200; i++)
        {
            M.transform.Translate(0f, 0.01f, 0);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}