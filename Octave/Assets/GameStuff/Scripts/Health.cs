using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	//fix this
	public int SoundHealth;
	public Image HealthBar;

	private void Start()
	{
		SoundHealth = 8; 
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Down"))
		{
			SoundHealth--; 
			//healthbar goes down; 
		}
	}

	private void Update()
	{
		if (SoundHealth <= 0)
		{
			//game over stuff, waitforseconds, respawn at the beginning of the level
		}
	}
}
