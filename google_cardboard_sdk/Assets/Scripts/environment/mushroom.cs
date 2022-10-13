using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//https://docs.unity3d.com/ScriptReference/Object.Destroy.html
public class mushroom : GazeableObject
{

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);  
        if(WoodMan.instance.activeMode == InputMode.COLLECT){  
            WoodMan.instance.collect_mushroom();
            Destroy(gameObject);
        }
    }

}
