﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Transform[] transArray;
    // Start is called before the first frame update
    void Start()
    {
        transArray = new Transform[2];
        transArray[1] = GameObject.FindWithTag("Blue").transform;
        transArray[2] = GameObject.FindWithTag("Red").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
