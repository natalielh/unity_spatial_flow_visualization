using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMatSwitcher : MonoBehaviour {

    public Material matToSwitchTo;

    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DomeCollider") {

            gameObject.GetComponent<Renderer>().material = matToSwitchTo;

        }
    }

}
