using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarScript : MonoBehaviour,IInteractableObject
{
    public SugarScript other;
    public HandController hands;

    public bool chose;
    public GameObject Picture;

    public void Interact()
    {
        if (!chose)
        {
            chose = true;
            other.chose = true;
            Picture.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
            Picture.SetActive(false);
            hands.MoveHBack();
        }
    }

    public bool ReInteract()
    {
        return false;
    }
}
