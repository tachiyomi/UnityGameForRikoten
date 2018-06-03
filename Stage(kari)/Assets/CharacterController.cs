using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    Rigidbody rb;
    Animator anim;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        anim.SetFloat("Velocity", rb.velocity.z);
        anim.SetFloat("Floating", rb.velocity.y);

        if (Input.GetKey(KeyCode.W) && rb.velocity.y == 0) {
            if (Input.GetKey(KeyCode.LeftShift))
                rb.velocity = new Vector3(0, 0, 4f);
            else
                rb.velocity = new Vector3(0, 0, 2f);
        }

        if (Input.GetKey(KeyCode.S) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector3(0, 0, -1.5f);
        }

        if (Input.GetKey(KeyCode.D) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector3(2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector3(-2f, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector3(0, 10f, 0);
            anim.SetTrigger("Jump!");
        }
    }
}
