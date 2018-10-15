using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour
{

	public AudioSource Note;

	private void OnTriggerEnter(Collider other)
	{
		Note.Play();
		gameObject.SetActive(false);
	}
	
	
}
