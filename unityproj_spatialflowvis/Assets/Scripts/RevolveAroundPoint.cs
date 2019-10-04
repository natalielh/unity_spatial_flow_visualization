using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveAroundPoint : MonoBehaviour {

    //[Range(-3.0f, 3.0f)]
    //public float speed;

    [Range(-20.0f, 20.0f)]
    public float degrees_per_second;

    public Vector3 point = new Vector3();

    // Use this for initialization
    void Start () {

        //point = new Vector3(0,0,0);

	}
	
	// Update is called once per frame
	void Update () {

        // Spin the object around the specified point at degrees_per_second degrees/second.
        transform.RotateAround(point, Vector3.up, degrees_per_second * Time.deltaTime);

    }
}
