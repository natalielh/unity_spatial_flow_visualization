using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMover : MonoBehaviour {

    public float moveInc = 0.05f;
    public float rotInc = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
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


}
