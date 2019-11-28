using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawLineTo : MonoBehaviour
{

    private LineRenderer lineRenderer;
    //private float dist;

    //public Transform origin; 'this' is the origin. the gameobject this script is attached to
    public Transform destination;

    // Use this for initialization
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.useWorldSpace = true;
        lineRenderer.widthMultiplier = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {

        if (destination != null)
        {
            lineRenderer.SetPosition(0, this.gameObject.transform.position);
            lineRenderer.SetPosition(1, destination.position);


            //dist = Vector3.Distance(origin.position, destination.position);
        }
    }

    //ref: https://www.youtube.com/watch?v=Bqcu94VuVOI
}
