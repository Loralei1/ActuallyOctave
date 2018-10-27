using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {

	public Text CountDown;
	//public Text EndText; 

	public float seconds = 1.0f;

	public int number = 60;

	//public GameObject EndGameObject;
	
	
 

	IEnumerator Start()

	{ 
		SetCountDownText();

		//label = GetComponent<Text>();

		while (number > 0)

		{

			yield return new WaitForSeconds(seconds);
			//SetCountDownText();
			//CountDown.text = "Time: " + number.ToString();

			number--;

			

		}

		yield return new WaitForSeconds(1);
		//EndText.text = "Cut";
		//ountDown.text = "Time: ";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!other.gameObject.CompareTag("Rest")) return;
		SetCountDownText();
		//CountDown.text = "Time: " + number.ToString();
		number = number + 10;
		
		if (!other.gameObject.CompareTag("Fermata")) return;
		SetCountDownText();
		//CountDown.text = "Time: " + number.ToString();
		number = number + 10;
	}
	
	void SetCountDownText()
	{
		CountDown.text = "Time: " + number.ToString();
		
	}


	private void Update()
	{
		if (number <= 0)
		{
			LevelChange();
			
		}
		
	}

	public void LevelChange()
	{
		SceneManager.LoadScene(2);
	}
}
