using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NodeEventHandler : MonoBehaviour {

    public delegate void NodeAction();
    public static event NodeAction OnInteract;

    public List<GameObject> inputPointGameObjects;
    //public List<GameObject> outputPointGameObjects;
    public GameObject outputPointGameObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Function() {
        OnInteract.Invoke();
    }

    public void PerformOperation() {

    }

}
