using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Light roomLight;
    public Light flashlight;
    public Transform ceiling;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.inputString == "o")
        {
            flashlight.intensity = 20;
        }
        if (Input.inputString == "f")
        {
            flashlight.intensity = 0;
        }


        if (transform.position.y >= 2)
        {
            roomLight.intensity = 0;
            //flashlight.intensity = 20;
            ceiling.position = new Vector3(0, 4.98f, 0);

        }
        else
        {
            roomLight.intensity = 6;
            //flashlight.intensity = 0;
            ceiling.position = new Vector3(0, 5, 0);
        }
    }
}
