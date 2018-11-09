using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Permissions;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {

	public Text CountDown; 

	public float seconds = 1.0f;

	public IntData number;

	//public GameObject EndGameObject;

	
	
	
 

	IEnumerator Start()

	{
		number.Value = 15; 
		SetCountDownText();

		//label = GetComponent<Text>();

		while (number.Value > 0)

		{

			yield return new WaitForSeconds(seconds);
			SetCountDownText();
			//CountDown.text = "Time: " + number.ToString();

			number.Value--;

			

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
		number.Value = number.Value + 10;
		
		//if (!other.gameObject.CompareTag("Fermata")) return;
		//SetCountDownText();
		//CountDown.text = "Time: " + number.ToString();
		//number.Value = number + 10;
	}
	
	void SetCountDownText()
	{
		CountDown.text = "Time: " + number.Value.ToString();
		
	}


	private void Update()
	{
		if (number.Value <= 0)
		{
		
			LevelChange();
			
		}
		
	}

	public void LevelChange()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
