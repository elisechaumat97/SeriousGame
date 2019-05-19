using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANQ_InstantiateCubes : MonoBehaviour
{
    public GameObject sampleCubePrefab;
    GameObject[] sampleCube = new GameObject[512];
    public float maxScale;

    void Start()
    {
        for(int i=0; i<512; i++)
        {
            GameObject instanceSampleCube = (GameObject)Instantiate(sampleCubePrefab);
            instanceSampleCube.transform.position = this.transform.position;
            instanceSampleCube.transform.parent = this.transform;
            instanceSampleCube.name = "SampleCube" + i;
            instanceSampleCube.transform.position = new Vector3(50+i,300,0);
            sampleCube[i] = instanceSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (sampleCube != null)
            {
                sampleCube[i].transform.localScale = new Vector3(10, (ANQ_AudioPeer.samples[i] * maxScale) + 2, 10); 
            }
        }
    }
}
