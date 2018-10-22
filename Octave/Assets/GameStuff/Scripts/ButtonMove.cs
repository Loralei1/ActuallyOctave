using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ButtonMove : MonoBehaviour
{
	private float dirX, dirY;

	[Range(1f, 20f)] public float moveSpeed = 3f;


	private Rigidbody rb;


	// Use this for initialization
	void Start()
	{

		rb = GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update()
	{

		dirX = /*CrossPlatform*/Input /*Manager*/.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		dirY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

		transform.position = new Vector2(transform.position.x - +dirX, transform.position.y - +dirY);

	}

	IEnumerator OnTriggerEnter(Collider other)

	{
		if (other.gameObject.CompareTag("Fermata"))
		{
			dirX = 0;
			dirY = 0; 
			yield return new WaitForSeconds(10);
			
			dirX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
			dirY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

			transform.position = new Vector2(transform.position.x - +dirX, transform.position.y - +dirY);

			
		}
	}
}