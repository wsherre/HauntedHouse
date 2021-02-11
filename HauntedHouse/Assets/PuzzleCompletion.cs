using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleCompletion : MonoBehaviour
{
    public GameObject art1;
    public GameObject art2;
    public GameObject art3;
    public GameObject art4;
    public GameObject art5;

    public float correctX1;
    public float correctX2;
    public float correctX3;
    public float correctX4;
    public float correctX5;

    private float currentX1;
    private float currentX2;
    private float currentX3;
    private float currentX4;
    private float currentX5;

    // Start is called before the first frame update
    void Start()
    {
        currentX1 = art1.transform.rotation.eulerAngles.x;
        currentX2 = art2.transform.rotation.eulerAngles.x;
        currentX3 = art3.transform.rotation.eulerAngles.x;
        currentX4 = art4.transform.rotation.eulerAngles.x;
        currentX5 = art5.transform.rotation.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        //currentX1 = (art1.transform.rotation.eulerAngles.x < 180f) ? art1.transform.rotation.eulerAngles.x : 360 - art1.transform.rotation.eulerAngles.x;
        //currentX2 = (art2.transform.rotation.eulerAngles.x < 180f) ? art2.transform.rotation.eulerAngles.x : 360 - art2.transform.rotation.eulerAngles.x;
        //currentX3 = (art3.transform.rotation.eulerAngles.x < 180f) ? art3.transform.rotation.eulerAngles.x : 360 - art3.transform.rotation.eulerAngles.x;
        //currentX4 = (art4.transform.rotation.eulerAngles.x < 180f) ? art4.transform.rotation.eulerAngles.x : 360 - art4.transform.rotation.eulerAngles.x;
        //currentX5 = (art5.transform.rotation.eulerAngles.x < 180f) ? art5.transform.rotation.eulerAngles.x : 360 - art5.transform.rotation.eulerAngles.x;

        currentX1 = art1.transform.rotation.eulerAngles.x;
        currentX2 = art2.transform.rotation.eulerAngles.x;
        currentX3 = art3.transform.rotation.eulerAngles.x;
        currentX4 = art4.transform.rotation.eulerAngles.x;
        currentX5 = art5.transform.rotation.eulerAngles.x;

        if (currentX1 > correctX1 - 1f && currentX1 < correctX1 + 1f)
        {
            if (currentX2 > correctX2 - 1f && currentX2 < correctX2 + 1f)
            {
                if (currentX3 > correctX3 - 1f && currentX3 < correctX3 + 1f)
                {
                    if (currentX4 > correctX4 - 1f && currentX4 < correctX4 + 1f)
                    {
                        if (currentX5 > correctX5 - 1f && currentX5 < correctX5 + 1f)
                        {
                            Destroy(this.gameObject);
                        }
                    }
                }
            }
        }
    }
}
