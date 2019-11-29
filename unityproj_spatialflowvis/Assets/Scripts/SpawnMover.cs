using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMover : MonoBehaviour {

    public float moveInc = 0.05f;
    public float rotInc = 5.0f;
    public float scaleInc = 0.001f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveDown();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotLeft();
        }

        if (Input.GetKey(KeyCode.Equals))
        {
            Grow();
        }

        if (Input.GetKey(KeyCode.Minus))
        {
            Shrink();
        }
    }

    public void MoveUp()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + moveInc, this.transform.position.z);
    }

    public void MoveDown()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - moveInc, this.transform.position.z);
    }

    public void RotRight()
    {
        //this.transform.rotation = new Vector3(this.transform.rotation.z, this.transform.rotation.y + rotInc, this.transform.rotation.z);
        Vector3 rot = new Vector3(this.transform.rotation.z, this.transform.rotation.y - rotInc, this.transform.rotation.z);
        this.transform.Rotate(rot);
    }

    public void RotLeft()
    {
        //this.transform.rotation = new Vector3(this.transform.rotation.z, this.transform.rotation.y - rotInc, this.transform.rotation.z);
        Vector3 rot = new Vector3(this.transform.rotation.z, this.transform.rotation.y + rotInc, this.transform.rotation.z);
        this.transform.Rotate(rot);
    }

    public void Grow()
    {
        //this.transform.localScale = this.transform.localScale + new Vector3(scaleInc, scaleInc, scaleInc);
        this.transform.localScale += new Vector3(scaleInc, scaleInc, scaleInc);
    }

    public void Shrink()
    {
        //this.transform.localScale = this.transform.localScale - new Vector3(scaleInc, scaleInc, scaleInc);
        //this.transform.localScale = new Vector3(this.transform.scale.x, this.transform.scale.y - scaleInc, this.transform.scale.z);
        this.transform.localScale -= new Vector3(scaleInc, scaleInc, scaleInc);
    }


}
