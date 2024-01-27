using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlushingTheFlush : MonoBehaviour,IInteractableObject
{
    //Declarations
    public bool neverSeenATrain = true;
    public GameObject Train;
    public GameObject ui;
    public GameObject player;
    public GameObject door;
    public GameObject wallToTrain;
    public void Interact()
    {
        if (neverSeenATrain)
        {
            Vector3 pos = new Vector3(transform.position.x +30, transform.position.y , transform.position.z - 2.15f);
            GameObject train = Instantiate(Train, pos, Quaternion.identity); // spawn train
            door.SetActive(true);
            wallToTrain.SetActive(false);
            neverSeenATrain = false;
            StartCoroutine(moveTrain(train)); // Train animation
        }
        else
        {
            Debug.Log("ye bharna h abhi");
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

    IEnumerator moveTrain(GameObject T)
    {
        for (int i = 0; i < 300; i++)
        {
            T.transform.Translate(-0.1f, 0, 0);
            yield return new WaitForSeconds(Time.deltaTime);
        }
        Debug.Log("GAME OVER!");
        ui.SetActive(true);
        player.transform.position = new Vector3(0f, 1.85f, 0f);
        Invoke("openEyes", 2);
        Destroy(T);
        wallToTrain.SetActive(true);
        door.SetActive(false); 
    }
}