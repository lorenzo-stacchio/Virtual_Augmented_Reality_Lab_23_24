using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.ChangeColor();
    }

    private void ChangeColor()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); 
    }

}

