using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
 public float distanceToMove;



    public float speed = 5f;
    public float direction = 1f;


    void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3 (
            
            transform.position.x + speed * direction * Time.deltaTime,
            transform.position.y,
            transform.position.z
        );
    }

}
