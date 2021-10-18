using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
This class as its aim goal that of define the process to controll a Button item with gazer. 
We suppose that a Button will always lies within a Menu identified by VRCanvas parentPanel. 

*/

[RequireComponent(typeof(Image))]

public abstract class GazeableButton : GazeableObject {


	// Use this for initialization
	public virtual void Start () {
		
	}

	// We suppose that every button have the property to change its color
	public void SetButtonColor(Color buttonColor)
	{
		GetComponent<Image>().color = buttonColor;
	}


	public override void OnPress(RaycastHit hitInfo)
	{
		base.OnPress (hitInfo);
		

	}

}
