using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{

	public GameObject[] Note;
	public Transform transform;

	public bool CanNote = true; 

	private GameObject getNote()
	{
		return Note[Random.Range(0, 4)];
	}
	

	IEnumerator Start()
	{
		while (CanNote)
		{
			yield return new WaitForSeconds(Random.Range(1, 8));
			{
				Instantiate(getNote(), transform.position, transform.rotation);
			}

		}
	}
}
