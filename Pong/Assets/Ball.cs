using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed;
   
	// Use this for initialization
	void Start () {
      
        float xDirection = Random.Range (-1f, 1f) ;
        float yDirection = Random.Range (-1f, 1f) ;
        while (xDirection < .4f && xDirection > .4f) {
            xDirection = Random.Range (-1f, 1f) ;


        }

        while (yDirection < .4f && yDirection > .4f) {
            yDirection = Random.Range(-1f, 1f) ;

        }
        Vector3 movement = new Vector3(xDirection, yDirection, 0);
        this.GetComponent<Rigidbody>().AddForce(movement * speed);
    }



    
	
	// Update is called once per frame
	void Update () {
		
	}
}
