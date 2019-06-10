using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerPrevious : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameManager.instance.PreviousScene();

    }
    
}
