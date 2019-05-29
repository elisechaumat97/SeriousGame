using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MenuHolder;

    public void MainMenu()
    {
        MenuHolder.SetActive(true);
    }

    public void Resume()
    {
        MenuHolder.SetActive(false);
    }

    public void Save()
    {

    }

    public void Options()
    {

    }

    public void Training()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }


}
