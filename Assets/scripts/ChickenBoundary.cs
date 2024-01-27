using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBoundary : MonoBehaviour
{
    public GameObject player;
    public ChickenInteract chickenInteract;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + 1.5f);
        gameObject.transform.parent = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
