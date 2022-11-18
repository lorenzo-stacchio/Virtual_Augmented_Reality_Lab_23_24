using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_color : MonoBehaviour
{
    /*
    This function returns a Color object which is defined by a triplet of float values, indicating the value of R,G and B channels that defines a color in the RGB space.
   */
    public void getRandomColor()
    {

        Color randomColor =
            new Color(Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f));

        this.gameObject.GetComponent<MeshRenderer>().material.color = randomColor;
        Debug.Log(randomColor);
    }
}
