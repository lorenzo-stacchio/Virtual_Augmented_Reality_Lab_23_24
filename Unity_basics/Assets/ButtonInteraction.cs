using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeText()
    {
        GameObject descriptionField = GameObject.Find("Description");
        descriptionField.GetComponent<TextMeshProUGUI>().text = "Text Changed " + counter.ToString();
        counter += 1;
    }
}
