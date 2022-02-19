﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject menu;
    public GameObject resume;
    public GameObject quit;
    public bool on;
    public bool off;

    void Start()
    {
        menu.SetActive(false);
        off = true;
        on = false;
    }

    void Update()
    {
        if (off && Input.GetButtonDown("pause"))
        {
            Time.timeScale = 0f;
            menu.SetActive(true);
            off = false;
            on = true;
        }
        else if (on && Input.GetButtonDown("pause"))
        {
            Time.timeScale = 1f;
            menu.SetActive(false);
            off = true;
            on = false;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        off = true;
        on = false;

    }
    public void Exit()
    {
        Application.Quit();
    }
}
