﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantObj : MonoBehaviour
{
	public GameObject Test;
	public Transform transform;
	
	
	public void SeeLevel()
	{
		Instantiate(Test, transform.position, transform.rotation);
	}

	
}
