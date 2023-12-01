using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDashPowerUp : MonoBehaviour
{
    [Header("References")]
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    private void OnTriggerEnter(Collider other)
    {
        Dashing dashing;

        dashing = other.GetComponentInParent<Dashing>();

        dashing.CollectPowerup();
    }
}
