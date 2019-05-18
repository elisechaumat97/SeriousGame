using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]

public class ANQ_AudioPeer : MonoBehaviour
{
    private new AudioSource audio;
    public static float[] samples = new float[512];
    public static float[] freqBand = new float[8];

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
    }

    void GetSpectrumAudioSource()
    {
        audio.GetSpectrumData(samples, 0, FFTWindow.Blackman);
    }

    void MakeFrequencyBands()
    {
        /*
         *  22050 / 512 = 43Hz
         *  
         *  20-60Hz
         *  60-250Hz
         *  250-500Hz
         *  500-2000Hz
         *  2000-4000Hz
         *  4000-6000Hz
         *  6000-20 000Hz
         *  
         *  0 - 2 = 86Hz
         *  1 - 4 = 172Hz   87-258
         *  2 - 8 = 344Hz   259-602    
         *  3 - 16 = 688Hz  603-1290
         *  4 - 32 = 1376Hz 1291-2666
         *  5 - 64 = 2752Hz 2667-5418
         *  6 - 128 = 5504Hz    5419-10922
         *  7 - 256 = 11008Hz   10923-21930
         *  510
         */

        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += samples[count] * (count + 1);
                count++;
            }
            average /= count;
            freqBand[i] = average * 10;
        }
    }
}