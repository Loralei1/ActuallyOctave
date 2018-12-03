using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Store", menuName = "Store/StoreFront")]
public class Store : ScriptableObject
{

	public Objects Available;
	public Objects Purchased;
	public IntData Cash;
	public GameObject Button;
	public GameObject Canvas;
	
	public UnityEvent MadePurchase;

	/*public void BuildUI()
	{
		var newCanvas = Instantiate(Canvas);
		var newButton = Instantiate(Button, newCanvas.GetComponentInChildren<VerticalLayoutGroup>().transform);
		var buttonComponent = newButton.GetComponent<Button>();
		buttonComponent.onClick.AddListener() => (MakePurchase(Purchased.ObjectList[0]);
		var labe = newButton.GetComponentInChildren<Text>();
		Label.text = Purchased.ObjectList[0].name; 

	}

	private void PurchaseButton();
	{
	}
	*/

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