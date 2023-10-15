using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered: " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited: " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Inside: " + gameObject.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
