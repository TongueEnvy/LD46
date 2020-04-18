using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_walk : MonoBehaviour
{

    public float moveSpeed;

    Transform cam;

    Vector3 forward;
    Vector3 right;

    CharacterController charCon;

    // Start is called before the first frame update
    void Start()
    {

        cam = GetComponent<cam_rotate>().cam.transform;

        charCon = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        forward = cam.forward;
        forward.y = 0;
        forward.Normalize();

        right = cam.right;
        right.y = 0;
        right.Normalize();

        Vector3 walkVector = (forward * Input.GetAxisRaw("Vertical")) + (right * Input.GetAxisRaw("Horizontal"));
        walkVector = (walkVector * moveSpeed);


        charCon.Move(walkVector);

    }
}
