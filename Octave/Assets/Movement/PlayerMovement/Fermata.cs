using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

public class Fermata : MonoBehaviour
{

	//private bool MoveEnabled;
	//public Rigidbody rb;
	public Give GivePattern;

	public void OnTriggerExit(Collider obj)
	{
		if (gameObject.CompareTag("Player"))
		{
			obj.GetComponent<MoveBase>().MovePattern = GivePattern.Transfer();
		}
			
	}


	/*IEnumerator OnTriggerEnter(Collider other)
	
	{
		if (gameObject.CompareTag("Fermata"))
		{
		    rb.constraints = RigidbodyConstraints.FreezeAll;
			yield return new WaitForSeconds(3);
			rb.constraints = RigidbodyConstraints.None;
		}

	}
*/

}
