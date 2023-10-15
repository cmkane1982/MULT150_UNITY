using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreCollision : MonoBehaviour
{
    public AudioClip audioClipName;
    int scoreCounter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        scoreCounter++;
        Debug.Log(gameObject.name + " hit " + scoreCounter + " times.");
        AudioSource.PlayClipAtPoint(audioClipName, transform.position);
    }

    private void OnGUI()
    {
        
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
