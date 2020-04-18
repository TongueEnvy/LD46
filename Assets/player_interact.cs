using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_interact : MonoBehaviour
{

    public float interDist;

    public int interMode;  //0 = do nothing, 1 = place in refiller, 2 = take from refiller, 3 = place in pump, 4 = remove from pump

    public canister_trackMode canMode;

    // Start is called before the first frame update
    void Start()
    {

        interMode = 0;

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit ,interDist))
        {

            if(hit.collider.gameObject.tag == "Refiller")
            {

                if(canMode.mode == 0)
                {

                    interMode = 2;

                }
                else if(canMode.mode == 2)
                {

                    interMode = 1;

                }

            }
            else if (hit.collider.gameObject.tag == "Pump")
            {

                if(canMode.mode == 1)
                {

                    interMode = 4;

                }
                else if(canMode.mode == 2)
                {

                    interMode = 3;

                }

            }

        }
        else
        {

            interMode = 0;

        }

        if (Input.GetButtonDown("Interact"))
        {

            if(interMode == 2 || interMode == 4)
            {

                canMode.mode = 2;

            }
            else if(interMode == 1)
            {

                canMode.mode = 0;

            }
            else if(interMode == 3)
            {

                canMode.mode = 1;

            }

        }

    }
}
