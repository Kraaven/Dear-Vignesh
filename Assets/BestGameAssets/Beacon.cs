using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Beacon : MonoBehaviour
{
    public NavMeshAgent agent;
    void Update()
    {
        agent.destination = gameObject.transform.position;
    }
}
