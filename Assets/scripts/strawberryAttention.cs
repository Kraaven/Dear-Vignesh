using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class strawberryAttention : MonoBehaviour,IInteractableObject
{
    [SerializeField] private TextMeshProUGUI strawberryAttention_text;
    [SerializeField] private GameObject text_strawberry;
    [SerializeField] private GameObject Panel_strawberry;
    [SerializeField] private AudioSource strawberryAlert;
    public void Interact()
    {
        Debug.Log("Strawberry Attention");
        text_strawberry.SetActive(true);
        StartCoroutine(panelShow());
        strawberryAttention_text.text = "Machuda";
    }

    IEnumerator panelShow()
    {
        yield return new WaitForSeconds(3);
        Panel_strawberry.SetActive(true);
        Panel_strawberry.transform.GetChild(0).gameObject.SetActive(true);
        strawberryAlert.GetComponent<AudioSource>().Play();

    }
    public bool ReInteract()
    {
        return false;
    }
    
}
