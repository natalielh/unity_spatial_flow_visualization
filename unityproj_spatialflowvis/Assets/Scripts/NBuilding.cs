using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NBuilding : MonoBehaviour {

    // This script handles the building node.
    Vector3 output = new Vector3();

    GameObject connectedNode1;  //expect NNum
    GameObject connectedNode2;  //expect NNum
    GameObject connectedNode3;  //expect NNum

    float input1 = 0.0f;
    float input2 = 0.0f;
    float input3 = 0.0f;


    // Update is called once per frame
    void Update () {

        //if (input1!=null && input2 != null && input1 != null) {
        //    Output();
        //}

        // check connected node's OUTPUT type validity
        if (connectedNode1 != null){
            if (connectedNode1.tag == "NNum") {

            }
        }

        if (connectedNode2 != null) {

        }

        if (connectedNode3 != null) {

        }

        else {
            // do not allow the invalid node to connect
        }

    }

    void Output() {

    }
}
