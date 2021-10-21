using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Magic_collision : MonoBehaviour
{

    MeshRenderer thisRenderer; // meshrender component of the object 
    Vector3 startPosition; // start position of the object in the x,y,z space
    float velocity = 1.0E-0f; // costant value fot the velocity of the object
    int left_right; //integer value used to decide in which direction a new ball will be created

    // Start is called before the first frame update


    void Start()
    {
        //init the render responsible for this object
        thisRenderer = GetComponent<MeshRenderer>();
        startPosition = this.transform.position;
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        var m_ObjectCollider = GetComponent<SphereCollider>();
        //Here the GameObject's Collider is not a trigger
        m_ObjectCollider.isTrigger = false;
        //decide if the ball will move left or right on the x axis
        left_right = (Random.Range(0.0f,1.0f) < 0.5 ? -1 : 1);
    }



   private void Update() {
       //change object position
       Vector3 oldPosition = this.transform.position;
       this.transform.position = new Vector3(oldPosition[0] + left_right*Time.deltaTime*velocity, oldPosition[1] , oldPosition[2]);
   }


   /*
   This function is called when the object "other" collide with this object or viceversa. 
   Our main goal is to change the color of the colliding object.
   */
    private void OnTriggerEnter(Collider other) {
       Material new_material = new Material(thisRenderer.material);
       Color new_color = getRandomColor(); 
       new_material.SetColor("_Color",  new_color);
       thisRenderer.material = new_material;
    }


   /*
   This function returns a Color object which is defined by a triplet of float values, indicating the value of R,G and B channels that defines a color in the RGB space.
   */
    private Color getRandomColor(){
       Color randomColor = new Color(Random.Range(0.0f,1.0f),
                                    Random.Range(0.0f,1.0f),
                                    Random.Range(0.0f,1.0f));
        return randomColor;
   }


   /*
   This function return a Vector3 type, indicating the position in which the object lies in x,y,z space at the start of the simulation.  
   */
   public Vector3 getStartPosition(){
      return startPosition;
   }
    
}
