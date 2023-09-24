using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    //int evenNum = 22;
    
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
        //if(evenNum <= 100)
        //{
        //    print(evenNum);
        //    evenNum += 2;
        //}
    }
}
