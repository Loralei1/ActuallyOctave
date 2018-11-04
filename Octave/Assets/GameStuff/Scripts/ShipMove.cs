using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

//I was originally trying to get the ship to move up and down with buttons
//because I was thinking this had to be for mobile
//but, then, I realized we could do it for pc (and that I didn't
//know how to configure things for mobile, so I decided to go ahead and use the 
//character controller we did in class, and I was trying to get the fermata thing
//(the player runs into it and gets stuck for ten seconds because in sheet music 
//it's a hold) to work using move pattern swaps, except then I couldn't get that to work,
//so I went back to this one and used a bool for the fermata bit. I'm probably 
//going to go back to the character controller and try to add a bool, but this 
//is working for now. 

public class ShipMove : MonoBehaviour
{
	public bool CanMove; 
	private float dirY;

	[Range(1f, 20f)] public float moveSpeed;


	private Rigidbody rb;
	


	// Use this for initialization
	void Start()
	{

		rb = GetComponent<Rigidbody>();
		CanMove = true; 
	}
	
	IEnumerator OnTriggerEnter(Collider other)

	{
		if (other.gameObject.CompareTag("Fermata"))
		{
			CanMove = false;
			yield return new WaitForSeconds(10);
			CanMove = true;

		}
	}


	
	void Update()
	{
		if (CanMove == true)
		{

			dirY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

			transform.position = new Vector2(transform.position.x, transform.position.y - +dirY);
		}

	}

	
	
}