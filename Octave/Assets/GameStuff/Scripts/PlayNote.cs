using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayNote : MonoBehaviour
{

	public AudioSource Tone;

	private void OnTriggerEnter(Collider other)
	
	
	{
		if(other.gameObject.CompareTag("Shot"))
		{
			Tone.Play();
		}
		
	}
}
