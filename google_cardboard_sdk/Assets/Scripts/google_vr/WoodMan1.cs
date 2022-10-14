using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WoodMan1 : myPlayer
{
    public static WoodMan1 instance; // woodman is a singleton
    private int mushrooms_collected;
    private TextMeshProUGUI punteggio;

    // Start is called before the first frame update
    public override void Start()
    {
        instance = this;
        this.punteggio = GameObject.Find("Punteggio").GetComponent<TextMeshProUGUI>();
        this.mushrooms_collected = 0;  
    }


    public void collect_mushroom(){
        this.mushrooms_collected +=1;
        this.punteggio.text = "Funghi raccolti: " + this.mushrooms_collected.ToString();
    } 

    public int collected_mushrooms(){
        return this.mushrooms_collected;
    }




}
