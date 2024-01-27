using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakecherry : MonoBehaviour,IInteractableObject
{

    public GameObject cherry, cherryHolder;
    [SerializeField] strawberryPick stpScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (stpScript.SBpickedup)
        {
            PutCherry();
        }
    }

    void PutCherry()
    {
        stpScript.SBpickedup = false;
        cherry.transform.SetParent(cherryHolder.transform);
        cherry.transform.position = cherryHolder.transform.position;
    }

    public bool ReInteract()
    {
        return false;
    }
}
