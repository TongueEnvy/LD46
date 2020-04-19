using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_checkIfVisible : MonoBehaviour
{

    public bool inView;

    public float dotTest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 forward = Camera.main.transform.forward;
        Vector3 fromCam = (transform.position - Camera.main.transform.position).normalized;

        float dotAngle = Vector3.Dot(fromCam, forward);

        if (dotAngle > dotTest)
        {

            inView = true;

        }
        else
        {

            inView = false;

        }

    }


}
