using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Mode
{
    Teleport,
    Collect
} 


public class Singleton : MonoBehaviour
{

    public static Singleton Instance;
    private Mode activeMode;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        this.activeMode = Mode.Teleport;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Test()
    {
        Debug.Log("Clicked " +  this.activeMode);
    }

}
