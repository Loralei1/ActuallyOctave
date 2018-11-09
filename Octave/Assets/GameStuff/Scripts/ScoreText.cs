﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

	public IntData Cash;
	public Text Countdown;

	private void Start()
	{
		Countdown.text = "Score: " + Cash.Value.ToString();
	}

	private void SetScoreText()
	{
		Countdown.text = "Score: " + Cash.Value.ToString();
	}

	private void Update()
	{
		SetScoreText();
	}
}
