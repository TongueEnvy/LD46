using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anom_causeFrenzy : MonoBehaviour
{

    public float attackDamage;

    public player_trackSanity trackSanity;

    public test_checkIfVisible visCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (visCheck.inView)
        {

            trackSanity.goingCrazy = true;
            trackSanity.sanityDrain += attackDamage * Time.deltaTime;
            trackSanity.drainTimer = 1.0f;

        }

    }
}
