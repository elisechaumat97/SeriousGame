using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float speed=100;
    Vector3 target;
    bool move = false;
    public Vector3 startingPosition;
    // Use this for initialization
    void Start()
    {
        transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
       
    {
        transform.rotation = new Quaternion(0,0,0,0);
        

        if (Input.GetMouseButtonDown(0))
        {
            move = true;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        if(move == true)
            {
            transform.position = Vector3.MoveTowards(transform.position, target, speed);

        }
        if (target == transform.position)
        {
            move = false;
        }
        

        

    }
   
    
}
