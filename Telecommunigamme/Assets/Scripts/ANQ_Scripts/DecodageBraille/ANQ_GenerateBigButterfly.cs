using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ANQ_GenerateBigButterfly : MonoBehaviour
{
    public GameObject bigButterfly;

    public int setBigButterflyNumber;
    public static int bigButterflyNumber;

    List<GameObject> cloneButterfly = new List<GameObject>();

    public List<Sprite> butterflyImages = new List<Sprite>();


    void Awake()
    {
        bigButterflyNumber = setBigButterflyNumber-1;
    }

    void Start()
    {
        for (int i = 0; i <= bigButterflyNumber; i++)
        {
            cloneButterfly.Add((GameObject)Instantiate(bigButterfly, new Vector3(2*i-bigButterflyNumber, 0, 0), Quaternion.identity));
            cloneButterfly[i].GetComponent<Image>().sprite=butterflyImages[i];
        }
    }

}
