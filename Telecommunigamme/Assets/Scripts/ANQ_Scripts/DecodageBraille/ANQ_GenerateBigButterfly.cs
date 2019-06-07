using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANQ_GenerateBigButterfly : MonoBehaviour
{
    public GameObject bigButterfly;
    public int bigButterflyNumber;

    void Start()
    {
        for (int i = 0; i <= bigButterflyNumber; i++)
        {
            Instantiate(bigButterfly, new Vector3(2*i-bigButterflyNumber, 0, 0), Quaternion.identity) as ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
