using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canister_trackMode : MonoBehaviour
{

    public int mode;  //0 = in refiller, 1 = in sedative pump, 2 = in hand

    public canister_trackContents trackContents;
    public director_trackStress trackStress;

    public Transform hand;
    public Transform fillAnchor;
    public Transform pumpAnchor;

    // Start is called before the first frame update
    void Start()
    {

        trackContents = GetComponent<canister_trackContents>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if(mode == 0)
        {

            trackContents.contents += Time.deltaTime * 2;
            trackContents.contents = Mathf.Clamp(trackContents.contents, 0, trackContents.capacity);
            transform.position = fillAnchor.transform.position;
            transform.rotation = fillAnchor.transform.rotation;

        }
        else if (mode == 1)
        {

            trackContents.contents -= Time.deltaTime * 2;
            trackContents.contents = Mathf.Clamp(trackContents.contents, 0, trackContents.capacity);
            transform.position = pumpAnchor.transform.position;
            transform.rotation = pumpAnchor.transform.rotation;
            if(trackStress.stress > 0 && trackContents.contents > 0)
            {

                trackStress.stress -= Time.deltaTime * 5;

            }


        }
        else if(mode == 2)
        {

            transform.position = hand.transform.position;
            transform.rotation = hand.transform.rotation;

        }

    }
}
