using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Purchace", menuName = "Store/Purchasable")]
public class PurchasableObject : ScriptableObject
{

	public Object Item;
	public int Value; 
	
}
