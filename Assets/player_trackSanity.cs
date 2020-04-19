using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_trackSanity : MonoBehaviour
{

    public float maxSanity;
    public float sanity;
    public float sanityDrain;
    public float sanityHealRate;
    public float drainTimer;

    public bool goingCrazy;

    // Start is called before the first frame update
    void Start()
    {

        sanity = maxSanity;

    }

    // Update is called once per frame
    void Update()
    {

        if (!goingCrazy)
        {

            sanity += sanityHealRate * Time.deltaTime;

        }
        else
        {
            sanity -= sanityDrain;

            drainTimer -= Time.deltaTime;

            if(drainTimer <= 0)
            {

                goingCrazy = false;

            }
        }

        if(sanity > maxSanity)
        {

            sanity = maxSanity;

        }

        if(sanity < 0)
        {

            sanity = 0;

        }

    }
}
