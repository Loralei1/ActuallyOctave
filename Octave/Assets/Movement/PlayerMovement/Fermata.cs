using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Fermata : MonoBehaviour
{

	private bool MoveEnabled;
	//public Rigidbody rb; 


	IEnumerator OnTriggerEnter(Collider other)
	
	{
		
		{
			//rb.constraints = RigidbodyConstraints.FreezeAll;
			MoveEnabled = false; 
			yield return new WaitForSeconds(3);
			MoveEnabled = true; 
			//rb.constraints = RigidbodyConstraints.None;
		}

	}


}
