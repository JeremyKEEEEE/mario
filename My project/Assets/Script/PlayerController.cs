using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	public bool canMove;
	private Rigidbody2D theRB2D;
	public float superJumpForce;
	public float teleport;	

	public bool grounded;
	public LayerMask whatIsGrd;
	public Transform grdChecker;
	public float grdCheckerRad;

	public float airTime;
	public float airTimeCounter;



    // Start is called before the first frame update
    void Start()
    {
        theRB2D = GetComponent<Rigidbody2D>();

	airTimeCounter = airTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
	{
		canMove = true;
	
	
	}
	Debug.Log(theRB2D.position.y);
		MovePlayer();
		Jump();
		SuperJump();
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
		if(theRB2D.position.y < -3.4)	 
		{
	
			if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
			{
				theRB2D.velocity = new Vector2(theRB2D.velocity.x, jumpForce);
			}
		}
		
		if(Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
		{
			if(airTimeCounter > 0)
			{
				theRB2D.velocity = new Vector2(theRB2D.velocity.x, jumpForce);
				airTimeCounter -= Time.deltaTime;	
			}
		
		}

		

		if(Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButton(0))
		{
		
			airTimeCounter = 0;
		}

		if(theRB2D.position.y < -3.4)
		{
			airTimeCounter = airTime;
		}










	}
	void SuperJump()
	{
		if(grounded == true)	 
		{
	
			if(Input.GetKeyDown(KeyCode.X))
			{
				theRB2D.velocity = new Vector3(theRB2D.velocity.x, superJumpForce);
			}
		}
		
		if(Input.GetKey(KeyCode.X))
		{
			if(airTimeCounter > 0)
			{
				theRB2D.velocity = new Vector3(theRB2D.velocity.x, superJumpForce);
				airTimeCounter -= Time.deltaTime;	
			}
		
		}

		

		if(Input.GetKeyUp(KeyCode.X))
		{
		
			airTimeCounter = 0;
		}

		if(grounded)
		{
			airTimeCounter = airTime;
		}

	}

	void Teleport()
	{
	
		if(Input.GetKeyUp(KeyCode.G))
		{
		

		
		}
	
	}



}


