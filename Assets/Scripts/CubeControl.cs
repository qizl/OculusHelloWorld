﻿using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            this.transform.Translate(0, 1f, 0);
        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(-.01f, 0, 0);
        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(.01f, 0, 0);
    }
}
