﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{

    public int scene;


    public void GoToNewLevel()
    {
        SceneManager.LoadScene(scene);
    }
}
