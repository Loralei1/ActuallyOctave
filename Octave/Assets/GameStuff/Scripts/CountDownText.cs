using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : MonoBehaviour {

	public IntData Time;
	public Text Countdown;

	private void Start()
	{
		Countdown.text = "Time: " + Time.Value.ToString();
	}

	private void SetScoreText()
	{
		Countdown.text = "Time: " + Time.Value.ToString();
	}

	private void Update()
	{
		SetScoreText();
	}
}
