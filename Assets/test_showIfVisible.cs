using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_showIfVisible : MonoBehaviour
{

    public Material greenMat;
    public Material redMat;

    public MeshRenderer mRender;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<test_checkIfVisible>().inView)
        {

            if(mRender.sharedMaterial != greenMat)
            {

                mRender.sharedMaterial = greenMat;

            }

        }
        else
        {

            if (mRender.sharedMaterial != redMat)
            {

                mRender.sharedMaterial = redMat;

            }

        }

    }
}
