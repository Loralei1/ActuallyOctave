using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{

	public GameObject Note;
	public Transform transform;

	public bool CanNote = true; 
	//public List<GameObject> notecount;
	//public GameObject AddMember; 

	//[Range(1f, 20f)] public float noteSeconds = 3f;
	

	IEnumerator Start()
	{
		while (CanNote)
		{
			yield return new WaitForSeconds(Random.Range(1, 8));
			//for (int i = 0; i < 1; i++)
			{
				Instantiate(Note, transform.position, transform.rotation);
			}

			//notecount.Add(AddMember.gameObject);
			//foreach (GameObject note in notecount) ;
			
			//Aaaaaand I haven't gotten this or the score to work quite right yet. 
			//The notes instantiate but I can't get the random things to instantiate.
		}
	}
}
