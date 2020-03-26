using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieRotTo : MonoBehaviour {

    public Transform objToStickTo;
	
	// Update is called once per frame
	void Update () {

        transform.rotation = objToStickTo.rotation;
		
	}
}
