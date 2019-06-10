using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public string[] scenesNames = new string[] { "Scene1working", "_Scene2", "_Scene3" };
    private static int currentScene=0;
    private static int previousScene=-1;
    public GameObject target;
    public GameObject player;
    public GameObject leftCollider;
    public GameObject rightCollider;
    public GameObject Alaia;
    // Start is called before the first frame update
    void Awake()

    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        SetUp();

    }

    public void SetUp()
       
    {



        if (currentScene > previousScene)
        {

            target.transform.position = leftCollider.transform.position;
            player.transform.position = leftCollider.transform.position;
        }
        else
        {
            target.transform.position = rightCollider.transform.position;
            player.transform.position = rightCollider.transform.position;

        }

        Alaia.SetActive(true);



    }
  
    public void NextScene()
    {
        previousScene = currentScene;
        currentScene += 1;
        Application.LoadLevel(scenesNames[currentScene]);
    }

    public void PreviousScene()
    {
        previousScene = currentScene;
        currentScene += -1;
        Application.LoadLevel(scenesNames[currentScene]);
        
    }


}
