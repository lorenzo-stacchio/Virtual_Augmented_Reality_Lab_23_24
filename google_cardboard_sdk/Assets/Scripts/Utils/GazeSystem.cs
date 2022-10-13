using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GazeSystem : MonoBehaviour {

	public GameObject reticle; 
	public Color inactiveReticleColor = Color.gray;
	public Color activeReticleColor = Color.green;

	private GazeableObject currentGazeObject;
	private GazeableObject currentSelectedObject;

	private RaycastHit lastHit;

	// Use this for initialization
	void Start () {
		SetReticleColor (inactiveReticleColor);
	}
	
	// Update is called once per frame
	void Update () {
		ProcessGaze ();
		CheckForInput (lastHit);
	}

	// added
	public void ProcessGaze()
	{
		Ray raycastRay = new Ray (transform.position, transform.forward);
		RaycastHit hitInfo;

		Debug.DrawRay (raycastRay.origin, raycastRay.direction * 100);

		if (Physics.Raycast (raycastRay, out hitInfo)) 
		{
			// Do something to the object

			// Check if the object is interactable
				// Get the gameobject from the hitInfo
			GameObject hitObj = hitInfo.collider.gameObject;
				// Check if the hit object is gazeable
			GazeableObject gazeObj = hitObj.GetComponentInParent<GazeableObject>();
			if (gazeObj != null) { // it is gazeable
				// Object we are looking at is different then before
				if (gazeObj != currentGazeObject) {
					ClearCurrentObject();
					currentGazeObject = gazeObj;
					currentGazeObject.OnGazeEnter (hitInfo);
					SetReticleColor(activeReticleColor);
				}
				// Object we are looking at is the same then before
				else {
					currentGazeObject.OnGaze (hitInfo);
				}
			}
			else {// hitObj is NOT gazeable
				ClearCurrentObject ();
			}
			lastHit = hitInfo;
		}
		else {// we are looking at "nothing"
			ClearCurrentObject ();
		}
	}


	private void SetReticleColor(Color reticleColor)
	{
		//Set the color of the reticle
		reticle.GetComponent<Renderer>().material.SetColor("_Color", reticleColor);
	}


	private void CheckForInput(RaycastHit hitInfo)
	{
		//Debug.Log(Input.GetMouseButton(0));
		//Debug.Log(currentGazeObject);
		if (currentGazeObject != null){
			//Debug.Log(currentGazeObject);
		}
		//Check for down (press the button, in that very moment)
		if (Input.GetMouseButtonDown (0) && currentGazeObject != null) {
			currentSelectedObject = currentGazeObject;
			currentSelectedObject.OnPress (hitInfo);
		}
		else if (Input.GetMouseButton (0) && currentGazeObject != null)
		{		//Check for hold (for frames after, with button stll down)
			currentSelectedObject.OnHold(hitInfo);
		}
		else if (Input.GetMouseButton(0) && currentGazeObject != null)
		{		//Check for hold (for frames after, with button stll down)
			currentSelectedObject.OnRelease(hitInfo);
			currentSelectedObject = null;
		}
	}


	private void ClearCurrentObject()
	{
		if (currentGazeObject != null) {
			currentGazeObject.OnGazeExit ();
			SetReticleColor (inactiveReticleColor);
			currentGazeObject = null;
		}
	}



}
