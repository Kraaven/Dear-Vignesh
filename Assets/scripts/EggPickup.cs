using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggPickup : MonoBehaviour, IInteractableObject
{
    public bool IsHoldingEgg;
    [SerializeField] private GameObject anchor;
    [SerializeField] private mouldMiniGame mmgScript;
    public void Interact()
    {
        if (!IsHoldingEgg)
        {
            EggInHand();
        }
    }

    public bool ReInteract()
    {
        return false;
    }

    void EggInHand()
    {
        Debug.Log("Egg Picked");
        IsHoldingEgg = true;
        gameObject.transform.SetParent(anchor.transform);
        gameObject.transform.position = anchor.transform.position;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    void EggUsed()
    {
        IsHoldingEgg = false;

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
