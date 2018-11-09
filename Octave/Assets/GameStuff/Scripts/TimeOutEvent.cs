using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeOutEvent : MonoBehaviour
{

	public UnityEvent Event;
	public IntData Time;

	private void Update()
	{
		if (Time.Value == 0)
		{
			Event.Invoke();
		}
	}
}
