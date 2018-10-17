using System.Collections;

using System.Collections.Generic;

using UnityEngine;



[RequireComponent(typeof(CharacterController))]

public class MoveBases : MonoBehaviour

{

	private CharacterController controller;
	public MovePattern MovePatterns;

	private void Start()

	{

		controller = GetComponent<CharacterController>();

	}

	void Update()

	{

		MovePatterns.Invoke(controller, transform);

	}

}
