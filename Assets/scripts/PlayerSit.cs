using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSit : MonoBehaviour
{
    public GameObject Sofa;

    public NotepadController check;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = Sofa.transform.position;
    
        gameObject.GetComponent<CharacterMovement>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        transform.Translate(-0.3f,0,0);
        
        check.CutEgg();
        check.ConvertStrawberry();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
