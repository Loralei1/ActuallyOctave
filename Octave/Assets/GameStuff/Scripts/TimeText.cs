using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{

	public IntData Time;
	public Text TimeOut;
	//public UnityEvent Event;

	private void Start()
	{
		TimeOut.text = "";
	}

	private void Update()
	{
		if (Time.Value <= 5)
		{
			SetTimeOutText();
		}
	}

	private void SetTimeOutText()
	{
		TimeOut.text = "Five Seconds Left!";
	}
}
