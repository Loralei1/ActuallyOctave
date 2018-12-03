using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayStartText : MonoBehaviour
{

	public Text One;
	public Text Two;
	public Text Three;
	public UnityEvent Event; 

	IEnumerator Start()

	{
		SetOneText();
		SetTwoText();
		SetThreeText();
		yield return new WaitForSeconds(2);
		One.text = "1. Shoot notes to score points.";
		//SetOneText();
		yield return new WaitForSeconds(2);
		Two.text = "2. Collide with rests to gain time.";
		//SetTwoText();
		yield return new WaitForSeconds(2);
		Three.text = "3. Avoid fermatas.";
		//SetThreeText();
		yield return new WaitForSeconds(3);
		Event.Invoke();
		
	}

	private void SetOneText()
	{
		One.text = "";
	}

	private void SetTwoText()
	{
		Two.text = "";
	}

	private void SetThreeText()
	{
		Three.text = "";
	}
	
	
	/*private void Update()
	{
		SetOneText();
		SetTwoText();
		SetThreeText(); 
	}*/
}
