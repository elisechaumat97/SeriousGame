using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerPrevious : MonoBehaviour
{
    //public GameObject Button;
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.instance.PreviousScene();

    }
    //private void OnTriggerExit2D(Collider2D col)
    //{
    //  Button.SetActive(false);

    // }
}
