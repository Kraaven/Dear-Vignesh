using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    [SerializeField] private GameObject VigneshBhaiya, Cake;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Vignesh");
        }

        if (other.gameObject.CompareTag("Cake"))
        {
            Debug.Log("Dead");
            SceneManager.LoadScene(0);
        }
    }
}
