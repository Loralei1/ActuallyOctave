using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.UI;

public class MoveEvent : MonoBehaviour
{


	public UnityEvent Event;

	public void OnMoveTrigger()
	{
		Event.Invoke(); 
	}
	

}
