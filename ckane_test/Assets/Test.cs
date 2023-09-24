using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 10; i >= 2; i -= 2)
        {
            print(i);
            print(Math.Log(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
