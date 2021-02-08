using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Light yo;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 1.5)
        {
            yo.intensity = 8;
        }
        else
        {
            yo.intensity = 0.1f;
        }
    }
}
