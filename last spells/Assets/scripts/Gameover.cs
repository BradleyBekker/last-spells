﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnGameOver()
    {
        SceneManager.LoadScene(0);
    }
}