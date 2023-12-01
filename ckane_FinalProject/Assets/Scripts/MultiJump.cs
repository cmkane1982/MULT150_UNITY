using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiJump : MonoBehaviour
{
    [Header("Multi Jumping")]
    public int numberOfJumps;

    [Header("References")]
    public Rigidbody rb;
    public PlayerMovement pm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
