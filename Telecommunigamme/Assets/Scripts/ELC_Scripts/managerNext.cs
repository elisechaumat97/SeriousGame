using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class managerNext : MonoBehaviour
{
    //public GameObject Button;
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.instance.NextScene();
    }
    
}
