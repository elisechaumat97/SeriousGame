using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ANQ_ParametersCodageMorse : MonoBehaviour
{
    public float cubeSize = 1f;
    public RectTransform cube;
    private void Start()
    {
        cube = GetComponent<RectTransform>();
        cube.sizeDelta = new Vector2(cubeSize, cubeSize);
    }


}






