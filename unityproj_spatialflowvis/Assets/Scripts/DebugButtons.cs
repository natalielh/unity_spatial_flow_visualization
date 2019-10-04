using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugButtons : MonoBehaviour {

    public float delay0;
    public float delay1;
    public float delay2;

    // Update is called once per frame
    void Update () {
		
        // LOAD SCENES BY PRESSING 0, 1, and 2 buttons on keyboard
        if (Input.GetKeyDown(KeyCode.Alpha0)){
            Invoke("LoadIntro", delay1);
            //LoadIntro();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)){
            Invoke("LoadMain", delay1);
            //LoadMain();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)){
            Invoke("LoadOutro", delay2);
            //LoadOutro();
        }

        // QUIT GAME BY PRESSING ESCAPE
        if (Input.GetKeyDown(KeyCode.Escape)){
            ExitApp();
        }
	}



    // THESE FUNCTIONS CAN ALSO BE ACCESSED BY OTHER SCRIPTS AND EVENTS
    public void LoadIntro(){
        SceneManager.LoadScene(0);
    }

    public void LoadMain(){
        SceneManager.LoadScene(1);
    }

    public void LoadOutro(){
        SceneManager.LoadScene(2);
    }

    public void ExitApp(){
        Application.Quit();
    }

    public void DoorExit() {
        Invoke("LoadOutro", delay2);
    }

}
