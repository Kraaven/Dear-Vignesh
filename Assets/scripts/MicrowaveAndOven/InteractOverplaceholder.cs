using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class InteractOverplaceholder : MonoBehaviour, IInteractableObject
{
    public GameObject ovenReturns;
    public GameObject anchor;
    public void Interact()
    {
        ovenReturns.GetComponent<Rigidbody>().useGravity = false;
        ovenReturns.transform.parent = gameObject.transform;
        ovenReturns.transform.rotation = transform.rotation;
        ovenReturns.transform.localScale = new Vector3(1, 1, 1);
        // over
        ovenReturns.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
    }
    public bool ReInteract()
    {
        return false;
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
