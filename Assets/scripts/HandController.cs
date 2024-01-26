using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(MoveHands());
    }

    IEnumerator MoveHands()
    {
        for (int i = 0; i < 240; i++)
        {
            transform.Translate(0,0,0.005f);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}
