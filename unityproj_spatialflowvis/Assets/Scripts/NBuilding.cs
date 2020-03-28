using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBuilding : MonoBehaviour {

    // This script handles the building node.
    Vector3 output = new Vector3();

    GameObject input1;
    GameObject input2;
    GameObject input3;

	
	// Update is called once per frame
	void Update () {

        if (input1!=null && input2 != null && input1 != null) {
            Output();
        }

	}

    void Output() {

    }
}
