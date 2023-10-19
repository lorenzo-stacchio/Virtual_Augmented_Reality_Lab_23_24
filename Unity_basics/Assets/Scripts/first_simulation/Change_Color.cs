using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color : MonoBehaviour
{
    MeshRenderer thisRenderer; // meshrender component of the object

    // Start is called before the first frame update
    void Start()
    {
        thisRenderer = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        Material new_material = new Material(thisRenderer.material);
        Color new_color = getRandomColor();
        new_material.SetColor("_Color", new_color);
        thisRenderer.material = new_material;
    }

    /*
    This function returns a Color object which is defined by a triplet of float values, indicating the value of R,G and B channels that defines a color in the RGB space.
   */
    private Color getRandomColor()
    {
        Color randomColor =
            new Color(Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f));
        return randomColor;
    }
}
