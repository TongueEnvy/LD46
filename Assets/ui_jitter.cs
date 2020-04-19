using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_jitter : MonoBehaviour
{
    public float xJitter;
    public float yJitter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float xPos = Random.Range(-xJitter, xJitter);
        float yPos = Random.Range(-yJitter, yJitter);

        GetComponent<RectTransform>().anchoredPosition = new Vector2(xPos, yPos);

    }
}
