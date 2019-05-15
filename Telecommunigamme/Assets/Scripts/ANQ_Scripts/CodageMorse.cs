using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodageMorse : MonoBehaviour
{
    public static int word=0; // indicate the word to code in morse (0:cerf, 1:2, 2:droite)
    public static int change = 0; // indicate if a word was just found
    public static int displayResult = 0; // indicate if textResult has to display

    public void ClickDot()
    {
        Text textMorse = GetComponent<Text>();
        if (change != 0)
        {
            textMorse.text = "";
            textMorse.color = Color.black;
            change = 0;
        }
        if (textMorse.text == "Code en morse les mots ci-dessus")
        {
            textMorse.text = "";
        }

            textMorse.text = textMorse.text+". ";
    }

    public void ClickUnderscore()

    {
        Text textMorse = GetComponent<Text>();
        if (change != 0)
        {
            textMorse.text = "";
            textMorse.color = Color.black;
            change = 0;
        }
        if (textMorse.text == "Code en morse les mots ci-dessus")
        {
            textMorse.text = "";
        }
        textMorse.text = textMorse.text + "_ ";
    }

    public void ClickSpace()

    {
        Text textMorse = GetComponent<Text>();
        if (change!=0)
        {
            textMorse.text = "";
            textMorse.color = Color.black;
            change = 0;
        }
        if (textMorse.text != "Code en morse les mots ci-dessus")
        {
            textMorse.text = textMorse.text + "   ";
        }

    }

    public void Verification()
    {
        Text textMorse = GetComponent<Text>();
        if (word==0)
        {
            if (textMorse.text == "_ . _ .    .    . _ .    . . _ . ")
            {
                textMorse.color = Color.green;
                change = 1;
                word = 1;
                displayResult = 1;
            }
        }
        if (word==1)
        {
            if (textMorse.text == ". . _ _ _ ")
            {
                textMorse.color = Color.green;
                change = 1;
                word = 2;
                displayResult = 1;

            }
        }
        if (word == 2)
        {
            if (textMorse.text == "_ . .    . _ .    _ _ _    . .    _    . ")
            {
                textMorse.color = Color.green;
                change = 1;
                word = 3;
                displayResult = 1;

            }
        }
    }
    public void TooLong()
    {
        Text textMorse = GetComponent<Text>();
        if (word == 0 & change!=1)
        {
            if (textMorse.text.Length > "_ . _ .    .    . _ .    . . _ . ".Length)
            {
                textMorse.color = Color.red;
                change = 1;
            }
        }
        if (word == 1 & change != 1)
        {
            if (textMorse.text.Length > ". . _ _ _ ".Length)
            {
                textMorse.color = Color.red;
                change = 1;
            }
        }
        if (word == 2 & change != 1)
        {
            if (textMorse.text.Length > "_ . .    . _ .    _ _ _    . .    _    . ".Length)
            {
                textMorse.color = Color.red;
                change = 1;
            }
        }
    }
    public void ClickDelete()
    {
        Text textMorse = GetComponent<Text>();


    }
}
