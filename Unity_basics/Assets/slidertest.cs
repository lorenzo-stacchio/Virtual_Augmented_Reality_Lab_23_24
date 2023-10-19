using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidertest : MonoBehaviour
{

    Slider mySlider;

    [SerializeField]
    GameObject toRotate; 

    // Start is called before the first frame update
    void Start()
    {
        this.mySlider = GetComponent<Slider>();
        this.mySlider.onValueChanged.AddListener(delegate (float f){ 
            Debug.Log(f.ToString() + " ciao " + this.mySlider.value.ToString());
            toRotate.GetComponent<testtesttest>().Rotate(f);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
