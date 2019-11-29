using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour {

    public GameObject prefab;
    public Material material;
    public float distance = 0.1f;

	// Use this for initialization
	void Start () {
        for (int i=0; i<21; i++) {
            for (int j=0; j<21; j++) {
                GameObject point = Instantiate(
                    prefab,
                    //new Vector3(
                    //    (-10f * distance) + (i * distance),
                    //    (-10f * distance) + (j * distance),
                    //    0
                    //),
                    //Quaternion.identity,
                    this.gameObject.transform,
                    false
                );
                //this.transform.parent = transform;
                point.transform.localPosition = new Vector3(
                        (1 / this.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                        (1 / this.transform.localScale.y) * ((-10f * distance) + (j * distance)),
                        0
                    );

            }

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
