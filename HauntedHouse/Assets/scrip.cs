using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    public int rotationAmt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void rotateObject()
    {
        transform.rotation *= Quaternion.Euler(rotationAmt, 0, 0);
    }

}
