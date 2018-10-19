using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour {

	public Text label;

	public float seconds = 1.0f;

	public int number = 120; 

	

	

	IEnumerator Start()

	{

		label = GetComponent<Text>();

		while (number > 0)

		{

			yield return new WaitForSeconds(seconds);

			label.text = number.ToString();

			number--;

			

		}

		yield return new WaitForSeconds(1);

		label.text = "Cut.";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!other.gameObject.CompareTag("Rest")) return;
		label.text = number.ToString();
		number = number + 10;
	}
}
