using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour {

    public bool dupeItself = true;
    public bool alwaysDupe = false;
    bool dupedYet = false;

    public GameObject objToSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Duplicate() {

        if (!alwaysDupe && !dupedYet) {

            if (!dupeItself)
            {
                Instantiate(objToSpawn, this.transform.position, Quaternion.identity);
            }
            else {
                Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
            }

            dupedYet = true;
        }

    }
}
