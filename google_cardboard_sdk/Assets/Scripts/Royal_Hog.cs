using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Royal_Hog : MonoBehaviour
{
    public static Royal_Hog instance; // woodman is a singleton
    private int mushrooms_collected;
    private TextMeshProUGUI punteggio;


    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
        this.punteggio = GameObject.Find("Info_Game_Text").GetComponent<TextMeshProUGUI>();
        this.mushrooms_collected = 0;  
    }


    public void collect_mushroom(){
        this.mushrooms_collected +=1;
        // this.punteggio.text = String.Format("Funghi raccolti: {0}/{1}", this.mushrooms_collected.ToString(), get_number_mushrooms);
        GameManager.collect_mushroom();
    } 

    public int collected_mushrooms(){
        return this.mushrooms_collected;
    }




}
