using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiro : MonoBehaviour
{
    public GameObject Alaïa;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Alaïa.transform.position.x - 2, Alaïa.transform.position.y, Alaïa.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        int HiroX = Mathf.RoundToInt(transform.position.x);
        int AlaïaX = Mathf.RoundToInt(Alaïa.transform.position.x);

        if (HiroX-AlaïaX <= -4) {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(Alaïa.transform.position.x - 4, Alaïa.transform.position.y, Alaïa.transform.position.z);
                transform.position = new Vector3(Alaïa.transform.position.x - 3.99f, Alaïa.transform.position.y, Alaïa.transform.position.z);
            }
            
           

        }
        if (HiroX - AlaïaX >= 4) {
     

            if (Input.GetKey(KeyCode.LeftArrow))
            {

                transform.position = new Vector3(Alaïa.transform.position.x + 4, Alaïa.transform.position.y, Alaïa.transform.position.z);

                transform.position = new Vector3(Alaïa.transform.position.x + 3.99f, Alaïa.transform.position.y, Alaïa.transform.position.z);
            }
}
    }
}