using System.Collections;

using System.Collections.Generic;

using UnityEngine;



[RequireComponent(typeof(CharacterController))]

public class MoveBase : MonoBehaviour

{

	private CharacterController controller;
	public MovePattern MovePattern;

	private void Start()

	{

		controller = GetComponent<CharacterController>();

	}

	void Update()

	{

		MovePattern.Invoke(controller, transform);

	}

}
