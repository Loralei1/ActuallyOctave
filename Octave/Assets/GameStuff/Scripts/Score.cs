using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{


	//public Text scoreText;

	public IntData Cash;

	public enum musicthings
	{
		QuarterNote,
		HalfNote,
		WholeNote,
		Rest,
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
			//other.gameObject.SetActive(false);

			switch (musicname)
			{
				case (musicthings.QuarterNote):
					Cash.Value = Cash.Value + 1;
					//SetScoreText();
					break;
				
				case (musicthings.HalfNote):
					Cash.Value = Cash.Value + 2; 
					//SetScoreText();
					break; 
				
				case (musicthings.WholeNote):
					Cash.Value = Cash.Value + 4; 
					//SetScoreText();
					break;
					
				case (musicthings.Rest):
					Cash.Value = Cash.Value - 8; 
					//SetScoreText();
					break;


			}
		}

	}

	/*void SetScoreText()
		{
			scoreText.text = "Score: " + Cash.Value.ToString();
		
			}*/

		}
	

	