using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {

	public Text CountDown;
	public Text EndText; 

	public float seconds = 1.0f;

	public int number = 60;

	public GameObject EndGame;
	public Transform transform; 

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
		EndText.text = "Cut";
		CountDown.text = "";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!other.gameObject.CompareTag("Rest")) return;
		CountDown.text = number.ToString();
		number = number + 10;
		
		if (!other.gameObject.CompareTag("Fermata")) return;
		CountDown.text = number.ToString();
		number = number + 10;
	}

	private void Update()
	{
		if (number <= 0)
		{
			Instantiate(EndGame, transform.position, transform.rotation);
			
		}
		
	}
}
