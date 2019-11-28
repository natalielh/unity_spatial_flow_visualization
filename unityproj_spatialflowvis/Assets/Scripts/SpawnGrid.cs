using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour {

    public GameObject point;
    public Material material;
    public float distance = 0.1f;

	// Use this for initialization
	void Start () {
        for (int i=0; i<21; i++) {
            Instantiate(point, new Vector3(0,1,2), Quaternion.identity, this.gameObject.transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
