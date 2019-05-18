using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANQ_ParamCube : MonoBehaviour
{
    public int band;
    public float startScale, scaleMultiplier;
    public bool useBuffer;
    Material mat;

    void Start()
    {
        mat = GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (ANQ_AudioPeer.bandBuffer[band] * scaleMultiplier) + startScale, transform.localScale.z);
        }
        if (!useBuffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (ANQ_AudioPeer.freqBand[band] * scaleMultiplier) + startScale, transform.localScale.z);

        }
    }
}
