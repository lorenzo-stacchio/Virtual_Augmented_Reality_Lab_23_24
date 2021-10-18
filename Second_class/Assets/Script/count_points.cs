using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class count_points : MonoBehaviour
{
    public manager_alley manager;

    private void OnTriggerEnter(Collider other) {
      //Debug.Log("gameobject" + other.gameObject);
      /*Check if the trigger is hitted by the ball or a pin!
      */
      if (other.gameObject.name == "ball")
        {
            manager.increase_hits();
        }
        else
        {
            manager.increase_points();
            // destroy pin
            Destroy(other.gameObject);
        } 
   }

}
