using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiePosTo : MonoBehaviour {

    public GameObject ObjToStickTo;
    public Vector3 offset = new Vector3();

    public bool stickRotation = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position = ObjToStickTo.transform.position + offset;
        if (stickRotation){this.transform.rotation = ObjToStickTo.transform.rotation; }


    }
}
