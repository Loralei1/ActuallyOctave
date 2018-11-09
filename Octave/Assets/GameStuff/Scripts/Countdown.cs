using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Security.Permissions;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {

	//public Text CountDown; 

	public float seconds = 1.0f;

	public IntData Time;

	//public GameObject EndGameObject;

	
	
	
 

	IEnumerator Start()

	{
		Time.Value = 15; 
		//SetCountDownText();

		//label = GetComponent<Text>();

		while (Time.Value > 0)

		{

			yield return new WaitForSeconds(seconds);
			//SetCountDownText();
			//CountDown.text = "Time: " + number.ToString();

			Time.Value--;

			

		}

		yield return new WaitForSeconds(1);
		//EndText.text = "Cut";
		//ountDown.text = "Time: ";
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!other.gameObject.CompareTag("Rest")) return;
		//SetCountDownText();
		//CountDown.text = "Time: " + number.ToString();
		Time.Value = Time.Value + 10;
		
		//if (!other.gameObject.CompareTag("Fermata")) return;
		//SetCountDownText();
		//CountDown.text = "Time: " + number.ToString();
		//number.Value = number + 10;
	}
	
	//void SetCountDownText()
	//{
	//	CountDown.text = "Time: " + Time.Value.ToString();
		
	//}


	private void Update()
	{
		if (Time.Value <= 0)
		{
		
			LevelChange();
			
		}
		
	}

	public void LevelChange()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
