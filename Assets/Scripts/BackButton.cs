﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    //When back button is pressed, menu scene is loaded.
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}