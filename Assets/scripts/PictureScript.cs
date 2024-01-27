using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIN());
    }

    IEnumerator FadeIN()
    {
        var pic = gameObject.GetComponent<Image>();
        for (float i = 0; i < 1 ; i+=0.05f)
        {
            pic.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.048f);
        }
    }
}
