using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public void Button_Click() => GameController.instance.MoveObject(this.transform.position);


}
