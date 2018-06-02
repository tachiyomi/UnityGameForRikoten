using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {
            rb.velocity = new Vector3(0, 0, 2f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -2f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-2f, 0, 0);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 50f, 0));
        }
    }
}
