using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	public bool canMove;
	private Rigidbody2D theRB2D;
	
	public bool grounded;
	public LayerMask whatIsGrd;
	public Transform grdChecker;
	public float grdCheckerRad;



    // Start is called before the first frame update
    void Start()
    {
        theRB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
	{
		canMove = true;
	
	
	}
	MovePlayer();
	Jump();

    }
	private void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle(grdChecker.position, grdCheckerRad, whatIsGrd);

	}

	void MovePlayer()
	{
		if(canMove)
		{
			theRB2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, theRB2D.velocity.y);
		}
	}
	void Jump()
	{
		if(grounded == true)	 
		{
	
			if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
			{
				theRB2D.velocity = new Vector2(theRB2D.velocity.x, jumpForce);
			}
		}
	}


}
