﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ 1.0f
        float v = Input.GetAxis("Vertical");

        transform.position += new Vector3(0, 0, 0.1f * h);

        Debug.Log("h=" + h + "v=" + v);
    }
}
