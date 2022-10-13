using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum InputMode
{
    NONE,
    TELEPORT,
    COLLECT
}


public class WoodMan : myPlayer
{
    public static WoodMan instance;
    public InputMode activeMode;
    public int mushrooms_collected;  


    // Start is called before the first frame update
    public override void Start()
    {
        instance = this;
        this.mushrooms_collected = 0;  
        this.activeMode = InputMode.NONE;
    }


    // Update is called once per frame
    public override void Update()
    {
        Debug.Log("user" + this.activeMode.ToString());
    }


    public void collect_mushroom(){
        this.mushrooms_collected +=1;
        //Debug.Log("Mushrooms collected");
        //Debug.Log(this.mushrooms_collected);
    } 

    public int collected_mushrooms(){
        return this.mushrooms_collected;
    }


}
