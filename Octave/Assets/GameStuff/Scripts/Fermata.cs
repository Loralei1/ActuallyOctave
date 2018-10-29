using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fermata : MonoBehaviour
{

	public bool CanMove;
	public Rigidbody rb; 
	
	private void Start()
	{
		rb = GetComponent<Rigidbody>();
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
}
