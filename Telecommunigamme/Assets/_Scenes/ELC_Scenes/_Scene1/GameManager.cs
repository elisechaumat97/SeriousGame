using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public GameObject cursor;
    public GameObject Alaia;
    public GameObject player;
    public GameObject target;
    private GameObject cloneAlaia;
    private GameObject cloneCursor;
    private Vector3 mouspos;
    private static int CurrentScene = 1;
    public static GameManager instance=null;
    private string[] Scenes = new string[] { "_Scene1", "_Scene2", "_Scene3" };
    // Use this for initialization

   
    void Start () {

		if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        cursor.transform.position = new Vector3(9.3f, mouspos.y, 1.1f);


        SetUp();
	}

    void Update()
        
    {
        mouspos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        mouspos = Camera.main.ScreenToWorldPoint(mouspos);
        Debug.Log(mouspos.x);
        if (mouspos.x >= 9.2f)
        {

            cursor.transform.position = new Vector3(9.3f, mouspos.y, -1.1f);
            if (Input.GetMouseButtonDown(0))
            {
                NextScene(CurrentScene);
            }
        }
        if (mouspos.x < 9.2f)
        {
            cursor.transform.position = new Vector3(9.3f, mouspos.y, 1.1f);
        }

    }
    public void SetUp() {
       
        cloneAlaia = Instantiate(Alaia, transform.position, Quaternion.identity) as GameObject;


    }
     
    void NextScene(int CurrentScene) {
        if (player.transform.position==target.transform.position)
               {

            CurrentScene += 1;
            Application.LoadLevel(Scenes[CurrentScene]);
        }
    }
   
   
    //private void SetUpPlayer() {
        //clonePlayer = Instantiate(player, transform.position, Quaternion.identity) as GameObject;

    //{
    
    

}
