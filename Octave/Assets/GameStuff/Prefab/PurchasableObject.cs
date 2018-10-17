using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Purchace", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{

	public Object Item;
	public int Value; 
	
}
//public UnityEvent MadePurchase 
//public IntData Cash; 
//public int TotalValue = 3000;
//var availableObject = Available.ObjectList[i]
// PurchasableObject available = Available.ObjectList[i] as PurchasableObject;
// if (availableObject == obj && Cash.Value >= availableObject.Value)
//{
//   Cash.Value -= availableObject.Value; 
	// Purchased.ObjectList.Add(obj);
	//Available.ObjectList.Remove(availableObject);
	//MadePurchase.Invoke

//public void PurchaseAll()
//{
 //if (Cash.Value >= TotalValue)
	//for (var i = 0; i< item in Available.ObjectList)
//}    Cash.Value -= TotalValue;
//Purchased.ObjectList.Add(item);  
		//Available.ObjectList.RemoveAt(0);
//}