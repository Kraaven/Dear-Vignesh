using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractMicrowave : MonoBehaviour , IInteractableObject
{
    public bool isInteracted = false;
    public GameObject player;
    public GameObject oven;
    public GameObject ovenReturns;
    public GameObject hand;
    public bool GetOven;
    public void Interact()
    {
        if (isInteracted && GetOven)
        {
            //Instantaite oven and give to anchor
            ovenReturns.transform.parent = hand.transform;
            ovenReturns.transform.localScale = new Vector3(0.3f, .3f, .3f);
            ovenReturns.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y,
                hand.transform.position.z);
            ovenReturns.gameObject.SetActive(true);
        }
        if (hand.transform.childCount == 1)
        {
            isInteracted = true;
            Destroy(oven);
        }

        StartCoroutine(PlayMicrowave());
    }
    
    public bool ReInteract()
    {
        return false;
    }

    IEnumerator PlayMicrowave()
    {
        //Play music
        yield return new WaitForSeconds(3);
        GetOven = true;
    }
}
