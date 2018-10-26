using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

	public Objects Available;
	public Objects Purchased;
	public IntData Cash;

	public UnityEvent MadePurchase;

	private void MakePurchase(PurchasableObject obj)
	{
		for (var i = 0; i < Available.ObjectList.Count; i++)

		{

	
			PurchasableObject availableObject = Available.ObjectList[i] as PurchasableObject;
			if (availableObject == obj && Cash.Value >= availableObject.Value)
			{
				Cash.Value -= availableObject.Value;
				Purchased.ObjectList.Add(obj);
				Available.ObjectList.Remove(availableObject);
				Debug.Log("Made Purchase");
				MadePurchase.Invoke();
			}


		}
	}

}