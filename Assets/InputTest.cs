﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Transition.Instance.LoadLevel("GameOverScene", 2f);
    
        }
    }
}
