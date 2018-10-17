using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatInputs : FloatData

{
 
	public string InputType;

	public override float Value
	
	

	{

		get { return Input.GetAxis(InputType)*value;}

	}

}
