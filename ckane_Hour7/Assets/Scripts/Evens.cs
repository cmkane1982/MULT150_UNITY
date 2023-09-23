using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int evenNum = 22; evenNum <= 100; evenNum += 2)
        {
            print(evenNum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
