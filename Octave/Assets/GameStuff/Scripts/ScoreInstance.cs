using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreInstance : MonoBehaviour
{

	public GameObject num;
	public Transform transform; 

	// Use this for initialization
	void Start ()
	{

		Instantiate(num, transform.position, transform.rotation);

	}
	
}
