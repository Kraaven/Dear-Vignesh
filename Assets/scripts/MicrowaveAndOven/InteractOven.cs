using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractOven : MonoBehaviour , IInteractableObject
{
    public bool isInHand = false;
    public GameObject anchor;
    public Collider boxCollider;
    public GameObject overPlaceholder;
    public void Interact()
    {
        Debug.Log("Microwave door opens to give hint to interact with oven");
        if (!isInHand)
        {
            InHand();
        }
    }
    public bool ReInteract()
    {
        return false;
    }

    public void InHand()
    {
        Debug.Log("");
        isInHand = true;
        overPlaceholder.SetActive(true);
        gameObject.transform.parent = anchor.transform;
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        gameObject.transform.position = new Vector3(anchor.transform.position.x, anchor.transform.position.y,anchor.transform.position.z);
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
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
