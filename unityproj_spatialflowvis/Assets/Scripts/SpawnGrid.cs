using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour {

    public GameObject prefab;

    public Material matX;
    public Material matY;
    public Material matZ;
    public Material mat1;

    public float distance = 0.1f;

	// Use this for initialization
	void Start () {
        for (int i=0; i<21; i++) {
            for (int j=0; j<21; j++) {

                //POINT 1
                GameObject point1 = Instantiate(
                    prefab,
                    this.gameObject.transform,
                    false
                );
                point1.transform.localPosition = new Vector3(
                        (1 / this.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                        (1 / this.transform.localScale.y) * ((-10f * distance) + (j * distance)),
                        0
                );
                //matX = GetComponent<Renderer>().material;
                

                //POINT 2
                GameObject point2 = Instantiate(
                    prefab,
                    this.gameObject.transform,
                    false
                );
                point2.transform.localPosition = new Vector3(
                        0,
                        (1 / this.transform.localScale.y) * ((-10f * distance) + (i * distance)),
                        (1 / this.transform.localScale.z) * ((-10f * distance) + (j * distance))
                );

                //POINT 3
                GameObject point3 = Instantiate(
                    prefab,
                    this.gameObject.transform,
                    false
                );
                point3.transform.localPosition = new Vector3(
                        (1 / this.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                        0,
                        (1 / this.transform.localScale.z) * ((-10f * distance) + (j * distance))
                );

            }

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
