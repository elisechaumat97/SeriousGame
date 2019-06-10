using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendFollower : MonoBehaviour
{
    public Transform leader;
    public GameObject target;
    public float followSharpness = 0.001f;
    private bool rotate=true;
    private int sens=-1;
    Vector3 _followOffset;

    void Start()
    {
        //this.transform.position = leader.position;
    }

    void Update_offSet()
    {

        if (target.transform.position.x < this.transform.position.x)
        {
            sens = 1;
        }
        else
        {
            sens = -1;
        }
        _followOffset = new Vector3(sens * 1.4f, -0.1f, 0);


    }
    void Update()
    {
        //Rotation
        this.transform.rotation = leader.rotation;

        Update_offSet();
        // Apply that offset to get a target position.
        Vector3 targetPosition = leader.position + _followOffset;

        // Keep our y position unchanged.
        targetPosition.z = transform.position.z;

        // Smooth follow.    
        transform.position += (targetPosition - transform.position) * followSharpness;
    }

    void LateUpdate()
  
    {
        
    }
}
