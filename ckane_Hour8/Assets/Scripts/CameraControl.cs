using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float mxVal = 0f;
    float myVal = 0f;

    public float sensitivity;

    public bool inverted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mouse Look
        mxVal += Input.GetAxis("Mouse X") * sensitivity;
        if (inverted)
            myVal += Input.GetAxis("Mouse Y") * sensitivity;
        else
            myVal += Input.GetAxis("Mouse Y") * -1 * sensitivity;

        transform.localEulerAngles = new Vector3(myVal, mxVal, 0);

        //// Mouse Move
        //mxVal = Input.GetAxis("Mouse X") * sensitivity;
        //if (inverted)
        //    myVal = Input.GetAxis("Mouse Y") * -1 * sensitivity;
        //else
        //    myVal = Input.GetAxis("Mouse Y") * sensitivity;

        //if (mxVal != 0)
        //    transform.Translate(mxVal, 0f, 0f);
        //if (myVal != 0)
        //    transform.Translate(0f, myVal, 0f);
    }
}
