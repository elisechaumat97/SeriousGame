using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : MonoBehaviour
{
    public float furthestY;     //Pour une perspective linéaire
    public float closestY;
    public float furthestScale; 
    public float closestScale;
    private Vector3 modifiedScale;
    // Update is called once per frame
    private void Update()
    {
        modifiedScale = new Vector3(furthestScale + ((transform.position.y - furthestY) / (closestY - furthestY)), furthestScale + ((transform.position.y - furthestY) / (closestY - furthestY)), 0);
        transform.localScale = modifiedScale;
    }
}
