using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Fermata : MonoBehaviour
{

	private bool hold; 


	public void OnTriggerEnter(Collider other)
	{
		hold = false;
		yield return WaitForSeconds(3);
		hold = false; 
	}

	IEnumerator Update()
	{
		yield return WaitForSeconds(3);
		hold = false; 
	}
}

public class yield
{
}
