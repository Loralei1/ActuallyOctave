using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Give: ScriptableObject{


	//public int PowerLevel;

	public MovePattern MovePatternTransfer;



	public MovePattern Transfer()

	{

		return MovePatternTransfer;

	}



}

