using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
This class works as a trait, because it main goal is to provide an interface but we could put implementations. 
To reach this goal, we use the virtual keyword which is used to declare a method, property, indexer, or event allowing
for it to be overridden in a derived class. 

To note that all the Unity scripts derives from MonoBehaviour object.
*/

public abstract class GazeableObject : MonoBehaviour {
	
	//Your fields here

	public virtual void OnGazeEnter(RaycastHit hitInfo)
	{
		//METHOD TO MANAGE ACTIONS WHEN RAYCAST ENTER THE OBJECT AREA 
		//Debug.Log ("Gaze entered on " + gameObject.name); 
		//YOUR CODE HERE
	}

	public virtual void OnGaze(RaycastHit hitInfo)
	{
		//METHOD TO MANAGE ACTIONS WHEN RAYCAST STAY IN THE OBJECT AREA 
		//Debug.Log ("Gaze hold on " + gameObject.name); 
		//YOUR CODE HERE
	}
	 
	public virtual void OnGazeExit()
	{
		//METHOD TO MANAGE ACTIONS WHEN RAYCAST EXIT THE OBJECT AREA 
		//Debug.Log ("Gaze exited on " + gameObject.name); 
		//YOUR CODE HERE
	}


	public virtual void OnPress(RaycastHit hitInfo)
	{
	    //METHOD TO MANAGE ACTIONS WHEN RAYCAST IS HOLDING AN OBJECT
		//Debug.Log ("Button hold"); 
		//YOUR CODE HERE
	}


	public virtual void OnHold(RaycastHit hitInfo)
	{
		//METHOD TO MANAGE ACTIONS WHEN RAYCAST IS HOLDING AN OBJECT
		//Debug.Log ("Button hold"); 
		//YOUR CODE HERE
	}


	public virtual void OnRelease(RaycastHit hitInfo)
	{
		//METHOD TO MANAGE ACTIONS WHEN RAYCAST RELEASE AN OBJECT
		//Debug.Log ("Button released");  
		//YOUR CODE HERE
	}


}
