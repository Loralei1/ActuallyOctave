using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownText : MonoBehaviour {

	public IntData Time;
	public Text Score;

	private void Start()
	{
		Score.text = "Time: " + Time.Value.ToString();
	}

	private void SetScoreText()
	{
		Score.text = "Time: " + Time.Value.ToString();
	}

	private void Update()
	{
		SetScoreText();
	}
}
