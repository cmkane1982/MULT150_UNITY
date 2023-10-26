using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    Vector3 lightPosition = new Vector3(1.0f, 1.0f, -5.0f); 
    // Start is called before the first frame update
    void Start()
    {
        for(int numLights = 0; numLights<10;numLights++)
        {
            Instantiate(prefab, lightPosition, transform.rotation);
            lightPosition.z += 2.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
