using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canister_trackContents : MonoBehaviour
{

    public float capacity;
    public float contents;

    public Transform fillBone;
    public Transform empty;
    public Transform full;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 ePos = empty.transform.position;
        Vector3 fPos = full.transform.position;

        float lerpTime = contents / capacity;

        fillBone.transform.position = Vector3.Lerp(ePos, fPos, lerpTime);

    }
}
