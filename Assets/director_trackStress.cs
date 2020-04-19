using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class director_trackStress : MonoBehaviour
{

    public float maxStress;
    public float stress;
    public float stressGrowthMod;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        stress += Time.deltaTime * stressGrowthMod;
        stress = Mathf.Clamp(stress, 0, maxStress);

    }
}
