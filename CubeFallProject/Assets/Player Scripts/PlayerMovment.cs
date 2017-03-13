using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour {

    public float speed = 5f;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -10)
            transform.position += Vector3.left * speed * Time.deltaTime;


        if (Input.GetKey(KeyCode.D) && transform.position.x < 10)
            transform.position -= Vector3.left * speed * Time.deltaTime;

    }



}
