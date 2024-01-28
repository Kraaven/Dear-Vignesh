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
    public void Interact()
    {
        if (!neverSeenATrain && canOderMilk)
        {
            laptop.GetComponent<AudioSource>().Play();
            StartCoroutine(rotateTheKeyboard(keyboard));
            if (milkscreenIsOn && !sequencecomplete)
            {
                milkScreen.SetActive(false);
                transactionScreen.SetActive(true);
                thought.DisplayThought("Milk Obtained", 0);
                sequencecomplete = true;
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
        return true;
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
        Debug.Log(gameObject.name);
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
}