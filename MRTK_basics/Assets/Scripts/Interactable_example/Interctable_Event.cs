using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class Interctable_Event : MonoBehaviour
{
    Interactable interactable; 

    // Start is called before the first frame update
    void Start()
    {
        this.interactable = this.gameObject.GetComponent<Interactable>();
        this.interactable.OnClick.AddListener(Custom_touch);
    }


    // Update is called once per frame
    void Custom_touch()
    {
        Debug.Log("Custom touch");
        change_color();
    }


    void change_color()
    {
          this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }



}
