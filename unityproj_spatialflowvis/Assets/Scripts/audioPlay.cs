﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof(AudioSource))]
public class audioPlay : MonoBehaviour
{
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");
    }

    
}