using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANQ_LightOnAudio : MonoBehaviour
{

    public int band;
    public float minIntensity, maxIntensity;
    Light _light;

    void Start()
    {
        _light = GetComponent<Light>();
    }

    void Update()
    {
        _light.intensity = (ANQ_AudioPeer.audioBandBuffer[band] * (maxIntensity - minIntensity)) + minIntensity;
    }
}
