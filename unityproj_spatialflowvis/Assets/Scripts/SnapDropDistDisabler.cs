using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapDropDistDisabler : MonoBehaviour {

    public Vector3 objLocationReference;
    public float distanceThreshold = 1.3f;

    private float nextActionTime = 0.0f;
    private float updateTime = 1f;

    private float deltaTime = 0.0f;

    // Update is called once per frame
    void Update () {

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (Time.time > nextActionTime) {

            if (Vector3.Distance(objLocationReference, transform.position) > distanceThreshold)
            //if (Vector3.Distance(transform.parent.parent.position, transform.position) > distanceThreshold)
            {
                disableSnapDropZone();
            }
            else
            {
                enableSnapDropZone();
            }
        }
	}

    void disableSnapDropZone()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    void enableSnapDropZone()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }

}
