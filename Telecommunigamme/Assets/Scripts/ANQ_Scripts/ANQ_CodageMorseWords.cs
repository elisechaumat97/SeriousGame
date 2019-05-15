using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANQ_CodageMorseWords : MonoBehaviour
{

    public void Update()
    {
        Text textResult = GetComponent<Text>();
        if (CodageMorse.word == 1 & CodageMorse.displayResult==1)
        {
            textResult.text = "CERF : _ . _ .    .    . _ .    . . _ . ";
            CodageMorse.displayResult = 0;

        }
        if (CodageMorse.word == 2 & CodageMorse.displayResult == 1)
        {
            textResult.text = textResult.text + Environment.NewLine+ "2 : . . _ _ _ ";
            CodageMorse.displayResult = 0;

        }
        if (CodageMorse.word == 3 & CodageMorse.displayResult == 1)
        {
            textResult.text = textResult.text + Environment.NewLine + "DROITE : _ . .    . _ .    _ _ _    . .    _    . ";
            CodageMorse.displayResult = 0;

        }
    }
}
