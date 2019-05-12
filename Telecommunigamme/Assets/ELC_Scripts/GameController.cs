using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
       
    {
        transform.rotation = new Quaternion(0,0,0,0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Vector3.right);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Vector3.left);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Vector3.up);

            }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Vector3.down);
        }
    }
}
