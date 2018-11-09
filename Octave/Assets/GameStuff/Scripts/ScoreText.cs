using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

	public IntData Cash;
	public Text Score;

	private void Start()
	{
		Score.text = "Score: " + Cash.Value.ToString();
	}

	private void SetScoreText()
	{
		Score.text = "Score: " + Cash.Value.ToString();
	}

	private void Update()
	{
		SetScoreText();
	}
}
