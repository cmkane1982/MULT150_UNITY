using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTransitions : MonoBehaviour
{
    Animator anim;
    //private char keyCode;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.inputString != "")
        //{
        //    keyCode = Input.inputString[0];
        //}

        //switch(keyCode)
        //{
        //    case 'A':
        //        anim.SetTrigger("Color");
        //        break;
        //    case 'D':
        //        anim.SetTrigger("Scale");
        //        break;
        //    case 'S':
        //        anim.SetTrigger("Spin");
        //        break;
        //    case 'W':
        //        anim.SetTrigger("Hover");
        //        break;
        //}

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Color");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Scale");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Spin");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Hover");
        }
    }
}
