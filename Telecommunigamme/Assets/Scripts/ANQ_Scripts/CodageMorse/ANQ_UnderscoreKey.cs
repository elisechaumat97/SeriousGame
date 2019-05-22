﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ANQ_UnderscoreKey : MonoBehaviour
{
    Button underscoreButton;

    void Start()
    {
        underscoreButton = GetComponent<Button>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("click");
            underscoreButton.onClick.Invoke();
        }
    }
}
