using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour {

    public bool dupeItself = true;
    public bool alwaysDupe = false;
    public bool reparent = true;

    bool dupedYet = false;

    // objToSpawn: set a PREFAB, this will be used if dupeItself == false
    public GameObject objToSpawn;
    // newParent: if == true, object will be reparented
    public Transform newParent;


    public void Duplicate() {

        if (!alwaysDupe && !dupedYet) {

            // reference to the CLONE gameObject created
            GameObject clone;

            // if dupe itself set to 'no'
            if (!dupeItself)
            {
                // then create the PREFAB in its place
                clone = Instantiate(objToSpawn, this.transform.position, Quaternion.identity);
            }
            // if dupe itself set to 'yes'
            else {
                // then create ITSELF in its place
                clone = Instantiate(this.gameObject, this.transform.position, Quaternion.identity);
            }

            // set parent
            if (reparent && (newParent != null)) {
                clone.transform.SetParent(newParent);
            }

            // set the flag to TRUE to prevent THIS from being duped again and again and again
            dupedYet = true;
        }

    }
}
