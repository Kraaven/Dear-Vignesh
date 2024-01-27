using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text dialogue;
    void Start()
    {
        dialogue = gameObject.GetComponent<TMP_Text>();
    }

    public void DisplayThought(String message, float delay)
    {
        StartCoroutine(ShowThought(message, delay));
    }

    IEnumerator ShowThought(String message, float delay)
    {
        dialogue.color = new Color(1, 1, 1, 1); 
        yield return new WaitForSeconds(delay);
        int length = message.Length;
        String displayedMessage = "";
        for (int i = 0; i < length; i++)
        {
            displayedMessage += message[i];
            dialogue.text = displayedMessage;
            yield return new WaitForSeconds(Time.deltaTime * 25);
        }

        yield return new WaitForSeconds(1.75f);
        Debug.Log("Fading");
        for (float i = 1; i > 0 ; i-=0.05f)
        {
            dialogue.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.048f);
        }
        dialogue.text = "";
    }
}
