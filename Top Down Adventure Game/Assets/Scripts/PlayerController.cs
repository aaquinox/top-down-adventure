using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; 
        if (Input.GetKey("w"))
        {
            //player moves up
            newPosition.y += speed;
        }

        if (Input.GetKey("s"))
        {
            //player moves down
            newPosition.y -= speed;
        }

        if (Input.GetKey("a"))
        {
            //player moves left
            newPosition.x -= speed;
        }

        if (Input.GetKey("d"))
        {
            //player moves right
            newPosition.x += speed;
        }

        transform.position = newPosition; 
    }

}
