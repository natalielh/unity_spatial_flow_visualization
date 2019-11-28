using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    private LineRenderer lineRenderer;
    private float dist;

    public Transform origin;
    public Transform destination;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.useWorldSpace = true;
        lineRenderer.widthMultiplier = 0.05f;
    }
	
	// Update is called once per frame
	void Update () {

        if (origin != null && destination != null)
        {
            lineRenderer.SetPosition(0, origin.position);
            lineRenderer.SetPosition(1, destination.position);


            dist = Vector3.Distance(origin.position, destination.position);
        }
    }

    //ref: https://www.youtube.com/watch?v=Bqcu94VuVOI
}
