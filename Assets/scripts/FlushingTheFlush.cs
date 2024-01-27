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
    
    public void Interact()
    {
        if (neverSeenATrain)
        {
            Vector3 pos = new Vector3(transform.position.x +30, transform.position.y , transform.position.z);
            GameObject train = Instantiate(Train, pos, Quaternion.identity); // spawn train
            StartCoroutine(moveTrain(train)); // Train animation
            if (train.transform.position.x <= -3f)
            {
                ui.SetActive(true);
                player.transform.position = new Vector3(0.22f, 1.85f, 1.24f);
                Invoke("openEyes", 2);
                Debug.Log("GAME OVER!");
                neverSeenATrain = false;
            }
        }
        else
        {
            //TODO:add this
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
        for (int i = 0; i < 350; i++)
        {
            T.transform.Translate(-0.1f, 0, 0);
            Debug.Log(T.transform.position.x);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}