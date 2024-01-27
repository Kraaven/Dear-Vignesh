using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitCouch : MonoBehaviour, IInteractableObject
{
    [SerializeField] private GameObject player;
    private bool isSitting;
    [SerializeField] CharacterMovement CMscript;
    
    
    // Start is called before the first frame update
    public void Interact()
    {
        if (!isSitting)
        {
            sitting();
        }
        else
        {
            standing();
        }
    }

    void sitting()
    {
        Debug.Log("Is sitting");
        isSitting = true;
        player.transform.position = gameObject.transform.position + new Vector3(0,2,0);
        player.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        CMscript.speed = 0;
    }

    void standing()
    {
        Debug.Log("Is Standing");
        isSitting = false;
        player.transform.position += new Vector3(0, 0.5f, 1.5f);
        player.transform.localScale = new Vector3(0.75f, 1, 0.75f);
        CMscript.speed = 4.5f;
    }

    public bool ReInteract()
    {
        return false;
    }
}
