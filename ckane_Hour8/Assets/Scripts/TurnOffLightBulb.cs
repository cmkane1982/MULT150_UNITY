using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOffLightBulb : MonoBehaviour
{
    Light lightBulb;

    // Start is called before the first frame update
    void Start()
    {
        lightBulb = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) || Input.GetMouseButtonDown(1))
        {
            lightBulb.enabled = !lightBulb.enabled;
        }
    }
}
