using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Jump : MonoBehaviour {
    
	public bool grounded = true;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
	public float jumpPower = 1;

	private void FixedUpdate()
	{
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}


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