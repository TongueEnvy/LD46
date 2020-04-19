using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_rotate : MonoBehaviour
{

    public float minAngle;
    public float maxAngle;
    public float lookSpeed;

    public Camera cam;

    Vector3 aimDir;

    // Start is called before the first frame update
    void Start()
    {

        aimDir = Vector3.zero;

    }

    // Update is called once per frame
    void Update()
    {

        aimDir = aimDir + new Vector3(Input.GetAxisRaw("Aim V"), Input.GetAxisRaw("Aim H"), 0);

        aimDir.x = Mathf.Clamp(aimDir.x, minAngle, maxAngle);

        cam.transform.eulerAngles = new Vector3(aimDir.x, aimDir.y, 0);

    }
}
