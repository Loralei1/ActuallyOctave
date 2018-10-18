﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{


	public Text ScoreText;

	public int scorenum;

	public enum musicthings
	{
		QuarterNote,
		HalfNote,
		WholeNote,
		EigthNote,
		Rest,
		Fermata
	};

	public musicthings musicname;

	private void Start()
	{
		
		//SetScoreText();
	}


	void OnTriggerEnter(Collider other)

	{
		if (other.gameObject.CompareTag("Shot"))
		{
			switch (musicname)
			{
				case (musicthings.QuarterNote):
					scorenum = scorenum + 2;
					ScoreText.text = scorenum.ToString();
					break;

				/*case (musicthings.HalfNote):
					scorenum = scorenum + 4;
					SetScoreText();
					break;

				case (musicthings.WholeNote):
					scorenum = scorenum + 8;
					SetScoreText();
					break;
				case (musicthings.Rest):
					scorenum = scorenum - 2;
					SetScoreText();
					break;
				case (musicthings.Fermata):
					scorenum = scorenum - 10;
					SetScoreText();
					break;
				case (musicthings.EigthNote):
					scorenum = scorenum + 1;
					SetScoreText();
					break;
			}

		}
			

		//if (other.gameObject.CompareTag("Note"))

		//{

		//	other.gameObject.SetActive(false);

		//	scorenum = scorenum + 1;

		//	SetScoreText();

		
	}

	void SetScoreText()
		{
			ScoreText.text = "Score: " + scorenum.ToString();
		*/
			}

		}
	}
}
	