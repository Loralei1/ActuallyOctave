using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoPurchaseText : MonoBehaviour
{

	public Text NotEnoughText;

	private void Start()
	{
		NotEnoughText.text = "";
	}


	private void Update()
	{
		SetNoteEnoughText();
	}

	public void SetNoteEnoughText()
	{
		NotEnoughText.text = "Not enough points!";
	}
}
