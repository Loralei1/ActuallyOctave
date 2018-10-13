using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{

	public GameObject Shot;

	private void OnMouseDown()
	{
		Instantiate(Shot, transform.position, transform.rotation);
	}
}
