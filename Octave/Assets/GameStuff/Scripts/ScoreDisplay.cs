using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{

	public Text ScoreText;
	public IntData Cash;

	private void Start()
	{
		ScoreText.text = "Current Score: " + Cash.Value.ToString();
	}
}
