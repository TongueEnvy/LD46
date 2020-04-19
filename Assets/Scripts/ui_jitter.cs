using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_jitter : MonoBehaviour
{
    public float xJitter;
    public float yJitter;
    public float jitterMod;

    public director_trackStress trackStress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        jitterMod = trackStress.stress / trackStress.maxStress;

        float xPos = Random.Range(-xJitter, xJitter) * jitterMod;
        float yPos = Random.Range(-yJitter, yJitter) * jitterMod;

        GetComponent<RectTransform>().anchoredPosition = new Vector2(xPos, yPos);

    }
}
