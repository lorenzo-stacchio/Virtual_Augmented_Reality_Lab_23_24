using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowling_ball : MonoBehaviour
{

    MeshRenderer thisRenderer; // meshrender component of the object 
    Vector3 startPosition; // start position of the object in the x,y,z space
    float velocity = 1.0E-0f; // costant value fot the velocity of the object
    int left_right; //integer value used to decide in which direction a new ball will be created

    // Start is called before the first frame update


   private void Update() {
       //change object position
       Vector3 oldPosition = this.transform.position;
       this.transform.position = new Vector3(oldPosition[0] + left_right*Time.deltaTime*velocity, oldPosition[1] , oldPosition[2]);
   }


   /*
   This function return a Vector3 type, indicating the position in which the object lies in x,y,z space at the start of the simulation.  
   */
   public Vector3 getStartPosition(){
      return startPosition;
   }
    
}

