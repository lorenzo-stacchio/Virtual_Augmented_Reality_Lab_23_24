using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Forest_Terrain : GazeableObject {
	public override void OnPress (RaycastHit hitInfo)
	{
		base.OnPress (hitInfo);
		Debug.Log(WoodMan.instance.activeMode);
		if (WoodMan.instance.activeMode == InputMode.TELEPORT) {
			Vector3 destLocation = hitInfo.point;
			destLocation.y = WoodMan.instance.transform.position.y;
			WoodMan.instance.transform.position = destLocation;
		}

	}
}
