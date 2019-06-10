using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour

{
    
    public void Button_Click_Next()

    {
  
        GameManager.instance.NextScene();
       
    }
    public void Button_Click_Previous()

    {
        GameManager.instance.PreviousScene();
    }
}
