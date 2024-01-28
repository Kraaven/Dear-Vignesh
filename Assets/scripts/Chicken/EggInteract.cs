using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EggInteract : MonoBehaviour, IInteractableObject
{
    public CharacterMovement characterMovement;
    public void Interact()
    {
        Destroy(gameObject);
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
