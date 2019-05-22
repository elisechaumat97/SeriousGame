using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ANQ_dotKey : MonoBehaviour
{
    Button dotButton;

    void Start()
    {
        dotButton = GetComponent<Button>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("click");
            dotButton.onClick.Invoke();
        }
    }
}
