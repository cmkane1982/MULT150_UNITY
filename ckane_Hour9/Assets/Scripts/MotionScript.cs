using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yDirection = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xDirection, yDirection, 0);
    }
}
