using System.Collections;
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
		yield return new WaitForSeconds(1);
		One.text = "1. Shoot notes to score points.";
		yield return new WaitForSeconds(1);
		Two.text = "2. Collide with rests to gain time.";
		yield return new WaitForSeconds(1);
		Three.text = "3. Avoid fermatas.";
		yield return new WaitForSeconds(2);
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
	
	
}
