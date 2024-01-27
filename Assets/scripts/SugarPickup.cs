using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarPickup : MonoBehaviour, IInteractableObject
{
    public bool IsHoldingSugar;
    [SerializeField] private GameObject anchor;
    [SerializeField] private mouldMiniGame mmgScript;
    public void Interact()
    {
        if (!IsHoldingSugar)
        {
            SugarInHand();
        }
    }

    public bool ReInteract()
    {
        return false;
    }

    void SugarInHand()
    {
        Debug.Log("Sugar Picked");
        IsHoldingSugar = true;
        gameObject.transform.SetParent(anchor.transform);
        gameObject.transform.position = anchor.transform.position;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    void SugarUsed()
    {
        IsHoldingSugar = false;

    }

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
