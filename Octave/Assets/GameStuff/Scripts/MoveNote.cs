using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNote : MonoBehaviour {

	private Rigidbody rb; 
	public float Speed; 

	void Start ()

	{

		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.right * Speed; 

	}

}
