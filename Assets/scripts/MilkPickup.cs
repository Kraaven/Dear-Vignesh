using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkPickup : MonoBehaviour, IInteractableObject
{
    public bool IsHoldingMilk;
    [SerializeField] private GameObject anchor;
    [SerializeField] private mouldMiniGame mmgScript;
    public void Interact()
    {
        if (!IsHoldingMilk)
        {
            MilkInHand();
        }
    }

    public bool ReInteract()
    {
        return false;
    }

    void MilkInHand()
    {
        Debug.Log("Milk Picked");
        IsHoldingMilk = true;
        gameObject.transform.SetParent(anchor.transform);
        gameObject.transform.position = anchor.transform.position;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    void MilkUsed()
    {
        IsHoldingMilk = false;

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
