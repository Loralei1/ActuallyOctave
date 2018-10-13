using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{

	public GameObject Note;
	public Transform transform;
	

	IEnumerator Start()
	{
		yield return new WaitForSeconds(2);
		for (int i = 0; i < 1; i++)
		{
			Instantiate(Note, transform.position, transform.rotation);
		}
		
	}
}
