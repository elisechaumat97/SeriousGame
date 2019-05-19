using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANQ_MorseResult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text textResult = GetComponent<Text>();
        if (CodageMorse.displayResult)
        {
            textResult.color = Color.green;
        }
    }
}
