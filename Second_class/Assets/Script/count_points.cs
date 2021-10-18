using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count_points : MonoBehaviour
{
    private int points = 0;
    private bool hit = false;
    private void OnTriggerEnter(Collider other) {
      Debug.Log("A pin touches the trigger");
      this.points+=1;
   }

    void Update()
    {
       Debug.Log("oooo");
       // get first of my childs which is the canvas  
       var father = this.transform.parent;
       var canvas = father.transform.GetChild(0);
       Text text_in_child_of_canvas = canvas.gameObject.GetComponentInChildren<Text>(); // in this case we want to access properties of the text object
       text_in_child_of_canvas.text = "Points: " + this.points;
    }
}
