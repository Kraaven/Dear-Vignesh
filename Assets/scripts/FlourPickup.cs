using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlourPickup : MonoBehaviour, IInteractableObject
{
    public bool IsHoldingFlour;
    [SerializeField] private GameObject anchor;
    [SerializeField] private mouldMiniGame mmgScript;
    public void Interact()
    {
        if (!IsHoldingFlour)
        {
            FlourInHand();
        }
    }

    public bool ReInteract()
    {
        return false;
    }

    void FlourInHand()
    {
        Debug.Log("Flour Picked");
        IsHoldingFlour = true;
        gameObject.transform.SetParent(anchor.transform);
        gameObject.transform.position = anchor.transform.position;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    void FlourUsed()
    {
        IsHoldingFlour = false;
        
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
