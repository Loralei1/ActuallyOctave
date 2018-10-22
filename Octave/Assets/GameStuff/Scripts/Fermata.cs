using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

public class Fermata : MonoBehaviour
{

	//private bool MoveEnabled;
	public Rigidbody rb;

	/*public Give GivePattern;

	public void OnTriggerEnter(Collider obj)
	{
		if (gameObject.CompareTag("Player"))
		{
			obj.GetComponent<MoveBase>().MovePattern = GivePattern.Transfer();
		}
			
	}*/
	void Start()
	{

		rb = GetComponent<Rigidbody>();
	}


	IEnumerator OnTriggerEnter(Collider other)

		{
			if (other.gameObject.CompareTag("Fermata"))
			{
				rb.constraints = RigidbodyConstraints.FreezeAll;
				yield return new WaitForSeconds(10);
				rb.constraints = RigidbodyConstraints.FreezeAll;
				rb.constraints = RigidbodyConstraints.FreezeRotationZ;
				rb.constraints = RigidbodyConstraints.FreezeRotationX;
				rb.constraints = RigidbodyConstraints.FreezeRotationY; 
			}

		}


	}

