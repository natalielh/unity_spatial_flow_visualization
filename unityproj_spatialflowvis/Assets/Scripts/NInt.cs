using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NInt : MonoBehaviour {

    public UnityEvent theEvent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void aFunction() {
        theEvent.Invoke();
    }

}
