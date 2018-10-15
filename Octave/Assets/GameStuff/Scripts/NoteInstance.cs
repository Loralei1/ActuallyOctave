using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{

	public GameObject Note;
	public Transform transform;

	public bool CanNote = true;  
	//public GameObject[] Notes; 

	//[Range(1f, 20f)] public float noteSeconds = 3f;
	

	IEnumerator Start()
	{
		while (CanNote)
		{
			yield return new WaitForSeconds(Random.Range(1, 8));
			//for (int i = 0; i < 1; i++)
			{
				//Instatiate(Notes.Random(somehow get this to pick random prefabs from the Notes array and instantiate those), transform.position, transform.rotation); 
				Instantiate(Note, transform.position, transform.rotation);
			}

			
		}
	}
}
