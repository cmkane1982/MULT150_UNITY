using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    public int lowEvenNumber;
    public int highEvenNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        if (lowEvenNumber % 2 != 0 || highEvenNumber % 2 != 0)
        {
            Debug.Log("Input numbers are not even.");
        }
        else
        {
            for (int evenNum = lowEvenNumber; evenNum <= highEvenNumber; evenNum += 2)
            {
                Debug.Log(evenNum);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
