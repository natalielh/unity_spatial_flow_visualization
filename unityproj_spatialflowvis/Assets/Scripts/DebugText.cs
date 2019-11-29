using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //need to import UnityEngine.UI to control the text displayed on the GUI

public class DebugText : MonoBehaviour
{

    private float nextActionTime = 0.0f;
    private float updateTime = 1f;

    private float deltaTime = 0.0f;

    public Text screenText;

    void Start()
    {
        //screenText = GameObject.Find("Canvas/DebugText").GetComponent<Text>();
        screenText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (Input.GetKeyDown(KeyCode.F1))
        {
            screenText.enabled = !screenText.enabled;
        }

        if (Time.time > nextActionTime)
        {
            nextActionTime += updateTime;
            float fps = 1.0f / deltaTime;
            screenText.text =
                // \n puts 'enter' in the string
                "PRESS F1 TO SHOW / HIDE THIS TEXT \n" +
                "[SPATIAL FLOW VISUALIZATION]  \n" +
                "[CREATED BY NATALIE LE HUENEN, contact@natalielehuenen.com]  \n" +
                "VERSION: [ALPHA-INTERNAL] \n" +
                "APPLICATION RUNNING ON: [" + Application.platform + "] \n" +
                "SCREEN RESOLUTION: [" + Screen.currentResolution + "] \n" +
                "FPS: [" + fps + "] \n" +
                "\n" +
                "[CONTROLS ARE AS FOLLOWS:] \n" +
                "[Z] SHOW / HIDE X-PLANE \n" +
                "[X] SHOW / HIDE Y-PLANE \n" +
                "[C] SHOW / HIDE Z-PLANE \n" +
                "[V] SHOW / HIDE POINT AXES \n" +
                "[1] SHOW / HIDE DEMO 1 \n" +
                "[2] SHOW / HIDE DEMO 2 \n"

            ;

        }


    }
}
