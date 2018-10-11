using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour {

	public FloatData gravity;
	public FloatData Speed;
	public Transform transform;
	public GameObject gameObject; 
	public Transform destination;
	private Transform newtransform; 

	private void Start ()
	{
		destination = transform; 


	}

	private void OnMouseDown()
	{
		destination = newtransform;
	}
}
