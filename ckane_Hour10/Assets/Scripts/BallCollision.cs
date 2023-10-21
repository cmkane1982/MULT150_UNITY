using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public AudioClip audioClipName;

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(audioClipName, transform.position);
    }
}
