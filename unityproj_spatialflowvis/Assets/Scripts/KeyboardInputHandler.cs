using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputHandler : MonoBehaviour {

    //public GameObject spawnPoint;
    //private SpawnGrid spawnGrid;

	// Use this for initialization
	void Start () {
        //spawnGrid = spawnPoint.GetComponent<SpawnGrid>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    spawnPoint.GetComponent<SpawnGrid>.XPlane.Toggle();
        //}


        // QUIT GAME BY PRESSING ESCAPE
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitApp();
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }

}
