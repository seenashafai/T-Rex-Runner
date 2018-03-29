using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Jump : MonoBehaviour {
	public bool grounded = true;
	public float jumpPower = 1;

   	void Update () 
    {
        if (Input.GetButtonDown("Jump") && grounded == true) 
        {
			JumpFunc ();
		}
	}

    void JumpFunc () 
    {
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
    }
}