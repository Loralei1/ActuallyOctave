using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTest : MonoBehaviour {
	
	public Text ScoreText;

	public int scorenum;
	
	private void Start()
	{
		scorenum = 0;
		SetScoreText();
	}
	
	void SetScoreText()
	{
		ScoreText.text = "Score: " + scorenum.ToString();
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Destroy")) ;

		{
		scorenum = scorenum + 1;
	    SetScoreText();
	    
		}
	}
}
