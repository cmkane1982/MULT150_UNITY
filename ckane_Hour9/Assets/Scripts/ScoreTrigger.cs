using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public AudioClip audioClipName;
    int scoreCounter = 0;

    void OnTriggerEnter(Collider other)
    {
        scoreCounter++;
        print(gameObject.name + " hit " + scoreCounter + " times.");
        AudioSource.PlayClipAtPoint(audioClipName, transform.position);
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
