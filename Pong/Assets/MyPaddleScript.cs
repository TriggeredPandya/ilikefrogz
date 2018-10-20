using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPaddleScript : MonoBehaviour
{

    public float speed;

    private Rigidbody rb; 

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {

        {

            if (Input.GetKey(KeyCode.W))
            {

                Vector3 movement = new Vector3 (0,-transform.position.y,0);

                rb.AddForce(movement * speed);

                print("up arrow key is held down");

            }

            else if (Input.GetKey(KeyCode.S))

            {


                Vector3 movement = new Vector3(0, transform.position.y, 0);

                rb.AddForce(movement * speed);


                print("down arrow key is held down");


            }

            
        }

     


    }

}
