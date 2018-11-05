using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Purchace", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{

	public Object Item;
	public int Value; 
	//public bool Perpetual; 
	//public bool Instantatable; 
	//public void CreateItem()
	//{
		 //if (Instantatable && Item is GameObject)
	//		{Instantiate(Item);}
	//}

}
