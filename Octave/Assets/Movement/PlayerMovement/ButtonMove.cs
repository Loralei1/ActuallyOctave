using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ButtonMove : MonoBehaviour
{
	private float dirX, dirY;

	[Range(1f, 20f)] public float moveSpeed = 3f;


	private Rigidbody2D rb;
	
	
	// Use this for initialization
	void Start ()
	{

		rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update ()
	{

		dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime; 
		
		transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);

	}
}
