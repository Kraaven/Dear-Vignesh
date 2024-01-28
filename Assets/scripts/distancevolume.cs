using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distancevolume : MonoBehaviour
{
    public GameObject Player, Enemy;

    public AudioSource dodo;
    // Start is called before the first frame update
    void Start()
    {
        dodo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(Player.transform.position, Enemy.transform.position)/100);
        dodo.volume = 1 - Vector3.Distance(Player.transform.position, Enemy.transform.position)/20;
    }
}
