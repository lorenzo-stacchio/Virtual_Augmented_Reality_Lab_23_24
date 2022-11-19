using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice_Custom_Actions : MonoBehaviour
{

    public void debug()
    {
        Debug.Log("Vocal commands captured");
    }


    public void debug_click()
    {
        Debug.Log("Click done");
    }


    public void change_color(GameObject to_color)
    {
        to_color.gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }



}
