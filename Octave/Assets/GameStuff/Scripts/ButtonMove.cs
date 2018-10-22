using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ButtonMove : MonoBehaviour
{
	public bool CanMove; 
	private float dirX, dirY;

	[Range(1f, 20f)] public float moveSpeed = 3f;


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


	// Update is called once per frame
	void Update()
	{
		if (CanMove == true)
		{

			dirX = /*CrossPlatform*/Input /*Manager*/.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
			dirY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

			transform.position = new Vector2(transform.position.x - +dirX, transform.position.y - +dirY);
		}

	}

	
	
}