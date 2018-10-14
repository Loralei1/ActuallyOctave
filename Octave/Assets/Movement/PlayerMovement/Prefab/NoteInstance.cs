using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{

	public GameObject Note;
	public Transform transform;
	//[Range(1f, 20f)] public float noteSeconds = 3f;
	

	IEnumerator Start()
	{
		yield return new WaitForSeconds(Random.Range(1, 8));
		for (int i = 0; i < 1; i++)
		{
			Instantiate(Note, transform.position, transform.rotation);
		}
		
	}
}
