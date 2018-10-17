using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class MovePatternNotGroundeds : MovePattern {



	public override void Invoke(CharacterController controller, Transform transform)

	{

		Move(transform);

		FinalMove(controller);

	}

}
