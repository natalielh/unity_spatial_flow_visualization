using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI; //need to import UnityEngine.UI to control the text displayed on the GUI
using Hashtable = ExitGames.Client.Photon.Hashtable;


public class DebugText : MonoBehaviour
{

    private float nextActionTime = 0.0f;
    private float updateTime = 1f;

    private float deltaTime = 0.0f;

    public Text screenText;
    public String projVer = "invalid version";

    void Start()
    {
        //screenText = GameObject.Find("Canvas/DebugText").GetComponent<Text>();
        screenText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

        if (Input.GetKeyDown(KeyCode.F2))
        {
            screenText.enabled = !screenText.enabled;
        }

        if (Time.time > nextActionTime)
        {
            nextActionTime += updateTime;
            float fps = 1.0f / deltaTime;
            screenText.text =
                // \n puts 'enter' in the string
                "Press F1 to Show / Hide VRSimulator controls \n" +
                "Press F2 to Show / Hide debug & console \n" +
                //"Press F3 to Show / Hide Console \n" +
                "\n" +
                "[SpatialFlow Holographic Interface VR Demo]  \n" +
                "Created by Natalie Le Huenen, natalie.lehuenen@gmail.com  \n" +
                "Learn more: [github.com/natalielh/unity_spatial_flow_visualization]  \n" +
                "\n" +
                "Version: ["+ projVer +"] \n" +
                "App running on: [" + Application.platform + "] \n" +
                "Screen resolution: [" + Screen.currentResolution + "] \n" +
                "FPS: [" + fps + "] \n" +
                "\n" +
                "Ping: [" + PhotonNetwork.GetPing() + "] \n" +
                "Server Address: [" + PhotonNetwork.ServerAddress + "] \n" +
                "Connected & Ready?: [" + PhotonNetwork.IsConnectedAndReady + "] \n" +
                "Is Master Client?: [" + PhotonNetwork.IsMasterClient + "] \n" +
                "Users in this Office: [" + PhotonNetwork.CurrentRoom.PlayerCount + "] \n" +
                "\n" +
                "Debug controls: \n" +
                "[Z] Show / Hide X-Plane \n" +
                "[X] Show / Hide Y-Plane \n" +
                "[C] Show / Hide Z-Plane \n" +
                "[V] Show / Hide Point Axes \n" +
                "[1] Show / Hide Demo 1 \n" +
                "[2] Show / Hide Demo 2 \n"

            ;

        }


    }
}
