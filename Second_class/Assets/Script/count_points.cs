using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count_points : MonoBehaviour
{
    //declare a GameObject which will be used to spawn a prefab
    [SerializeField]
    private GameObject sphereToSpawn;
    private int points = 0;

    private void OnTriggerEnter(Collider other) {
      Debug.Log("A pin touches the trigger");
      points+=1;
   }

    void Update()
    {
       // TODO: implementa cambio punteggio sulla scritta del testo del canvas, prendi componente testo e cambialo
       //Debug.Log(transform.GetSiblingIndex());
       //int my_index = transform.GetSiblingIndex();
       //int child_of_parent = transform.parent.childCount; //it is two
       //this.transform.parent.GetChild(0).GetChild(0).GetComponents();//<Text>().text = "Actual points: " + points;
       //Debug.Log(child_of_parent);
       //Debug.Log(transform.GetSiblingIndex());
       //this.transform.parent.Find("Text").GetComponent<Text>().text = "Actual points: " + points;
    }
}
