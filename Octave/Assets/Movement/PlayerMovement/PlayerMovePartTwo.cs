using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovePartTwo : MonoBehaviour
{

	float directionY;
	[Range(1f, 20f)] public float moveSpeed = 3f; 
	

	void Update()
	{
		directionY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
	}
}
