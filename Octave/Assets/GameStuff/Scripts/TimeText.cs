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
	//public Text TimeOut;
	public UnityEvent Event;

	public void Update()
	{
		if (Time.Value == 5)
		{
			Event.Invoke();
			
		}
		
	}
}
