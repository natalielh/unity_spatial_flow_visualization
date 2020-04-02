using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables.ArtificialBased;

public class ScaleObj : MonoBehaviour {

    //public VRTK_ArtificialSlider slider = new VRTK_ArtificialSlider();
    public VRTK_ArtificialSlider slider;
    Vector3 toScale = new Vector3();

	
	// Update is called once per frame
	void Update () {

        toScale.x = 0.1f + slider.GetNormalizedValue();
        toScale.y = 0.1f + slider.GetNormalizedValue();
        toScale.z = 0.1f + slider.GetNormalizedValue();

        this.transform.localScale = toScale;
	}
}
