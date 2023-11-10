using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject[] wall;
    private void OnTriggerEnter(Collider other)
    {
        foreach(GameObject go in wall)
        {
            go.GetComponent<MoveWalls>().enabled = true;
        }
    }
}
