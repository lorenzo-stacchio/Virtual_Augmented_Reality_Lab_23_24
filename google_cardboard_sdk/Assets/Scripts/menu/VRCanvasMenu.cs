using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCanvasMenu : VRCanvas {

	public Menu_button currentActiveButton;
	public Color unselectedColor = Color.white;
	public Color selectedColor = Color.green;

	// Use this for initialization
	public override void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Start();
		LookAtPlayer ();
	}


	public void SetActiveButton(Menu_button activeButton)
	{
		// If there was previously active button, disable it
		if (currentActiveButton != null) {
			//set player mode to none and change color button
			currentActiveButton.SetButtonColor(unselectedColor);
			WoodMan.instance.activeMode = InputMode.NONE;
		}
		if (activeButton != null && currentActiveButton != activeButton) {
			currentActiveButton = activeButton;
			currentActiveButton.SetButtonColor(selectedColor);
			WoodMan.instance.activeMode = activeButton.getMode();
			//Debug.Log("player setting in VR CANVAS" + WoodMan.instance.activeMode.ToString());
		} else {
			//Debug.Log ("Resetting");
			currentActiveButton = null;
			WoodMan.instance.activeMode = InputMode.NONE;
		}
	}

	public void LookAtPlayer()
	{
		Vector3 playerPos = WoodMan.instance.transform.position; //player position
		Vector3 vecToPlayer = playerPos - transform.position; //distance between the player and the VRCanvas
		Vector3 lookAtPos = transform.position - vecToPlayer; //position vector used in the lookAt method  
		//Debug.Log("player pos" + playerPos.ToString());
		//Debug.Log("vecToPlayer" + vecToPlayer.ToString());
		//Debug.Log("lookAtPos" + lookAtPos.ToString());
		// Rotate the Menu so it keeps looking at the player
		transform.LookAt (lookAtPos);
	}
}
