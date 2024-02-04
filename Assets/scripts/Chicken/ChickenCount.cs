using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ChickenCount : MonoBehaviour
{
    // Start is called before the first frame update
    private int Count;
    private Collider boxCollider;
    public GameObject chickenObj;
    private Vector3 chickenPos;
    public GameObject Egg;
    public GameObject fatherFigure;
    
    
    void Start()
    { 
        Count = 0;
        boxCollider = gameObject.GetComponent<BoxCollider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        if (Count == 10 || Count == 20 || Count == 30)  
        {
            chickenPos = chickenObj.transform.position + new Vector3(0,-1,0);
            Instantiate(Egg, chickenPos, transform.rotation);
            Debug.Log("Spawning egg");
            Egg.SetActive(true);
            GameObject.FindObjectOfType<ChickenInteract>().eggs++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Count += 1;
        if (Count == 10 || Count == 20 || Count == 30)  
        {
            chickenPos = chickenObj.transform.position + new Vector3(-0,-1,0);
            Instantiate(Egg, chickenPos, transform.rotation);
            Debug.Log("Spawning egg");
            Egg.SetActive(true);
            Egg.transform.parent = fatherFigure.transform;
            GameObject.FindObjectOfType<ChickenInteract>().eggs++;
        }
    }   
    private void Update()
    {
        
    }
}
