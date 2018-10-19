using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {

	public Text CountDown;

	public float seconds = 1.0f;

	public int number = 120; 

	IEnumerator Start()

	{

		//label = GetComponent<Text>();

		while (number > 0)

		{

			yield return new WaitForSeconds(seconds);

			CountDown.text = number.ToString();

			number--;

			

		}

		yield return new WaitForSeconds(1);

		CountDown.text = "Cut.";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!other.gameObject.CompareTag("Rest")) return;
		CountDown.text = number.ToString();
		number = number + 10;
	}
}
