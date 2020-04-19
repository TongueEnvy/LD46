using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class post_frenzyVisuals : MonoBehaviour
{

    public float lerpTime;

    public player_trackSanity trackSanity;

    public Volume post;

    public SplitToning sTone;
    public Vignette vign;

    public Gradient highlightGrad;
    public Gradient shadowGrad;

    // Start is called before the first frame update
    void Start()
    {

        post.profile.TryGet<SplitToning>(out sTone);
        post.profile.TryGet<Vignette>(out vign);

    }

    // Update is called once per frame
    void Update()
    {

        lerpTime = 1 - (trackSanity.sanity / trackSanity.maxSanity);

        Color newHighlight = highlightGrad.Evaluate(lerpTime);
        Color newShadows = shadowGrad.Evaluate(lerpTime);

        sTone.highlights.Override(newHighlight);
        sTone.shadows.Override(newShadows);
        vign.intensity.Override(lerpTime * 0.25f);

    }
}
