using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class navagent : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
    }
}
