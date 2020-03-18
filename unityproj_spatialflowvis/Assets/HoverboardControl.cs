using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverboardControl : MonoBehaviour {

    public float speed = 1.0f;
    public GameObject hoverboard;
	
	// Update is called once per frame
	void Update () {

//        transform.Translate(Vector3.forward * OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick) * speed * Time.deltaTime);

    }

    public void MoveForward() {
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Debug.Log("Hoverboard moving FORWARD");
    }

    public void MoveBackward() {
        this.transform.Translate( -1.0f * Vector3.forward * speed * Time.deltaTime);
    }

    public void MoveLeft()
    {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        this.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
