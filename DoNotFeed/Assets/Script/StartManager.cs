﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {
    
    public void StartGame()
    {
        Application.LoadLevel("Stage1");   
    }
}