using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    // Manage the object collisions
    private void OnCollisionEnter(Collision other)
    {
        //this is necessary since enabling a unity script means activating it's main methods as Start() or Update()
        //but other methods could still be called!
        if (this.enabled)
        {
            //Inibit scripting of other object
            // game object in this case refers to the gameobject the Collider is attached
            Change_Color otherscript =
                other.gameObject.GetComponent<Change_Color>();
            if (otherscript != null)
            {
                otherscript.enabled = false;
            }
            Debug.Log("The sphere is colliding");
            // game object refers to the object the script is attachet to!
            gameObject.AddComponent<Change_Color>();
        }
    }

}
