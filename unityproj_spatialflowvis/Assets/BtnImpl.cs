using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnImpl : MonoBehaviour {

    private Vector3 origPos = new Vector3();

    public float offset = 0.05f;

	// Use this for initialization
	void Start () {
        origPos = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider) {

        transform.Translate(Vector3.down * offset);
    //    transform.localPosition.y = origPos.y - offset;
    }

    void OnTriggerExit(Collider collider)
    {
        transform.localPosition = origPos;
    }

}
