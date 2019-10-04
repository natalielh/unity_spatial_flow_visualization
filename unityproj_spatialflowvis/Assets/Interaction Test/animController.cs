


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

	public Animator anim;

    

    // Use this for initialization
    void Start () {
		Cursor.visible=false;
		anim = GetComponent<Animator> ();
	
		
	}
	
	// Update is called once per frame
	void Update () {

	

		if (Input.GetKeyDown ("1")) {
			anim.Play ("bookOpen");
            Debug.Log("ballUp anim playing");
		} else if (Input.GetKeyDown ("2")) {
			anim.Play ("bookDefault");
            Debug.Log("ballDefault anim playing");
		}

    
        

    }

    public void playAnim()
    {
        anim.Play("bookOpen");
        Debug.Log("ballUp anim playing");
    }
}
