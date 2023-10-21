using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    public int hitPoints = 1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == gameObject.tag || collision.collider.tag == "Chaos")
        {
            hitPoints--;

            if (hitPoints == 0)
            {
                Destroy(gameObject);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
