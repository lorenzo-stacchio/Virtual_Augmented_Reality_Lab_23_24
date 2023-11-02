using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum ModePlayer
{
    Teleport, 
    Collect
}


public class Singleton2 : MonoBehaviour
{

    public ModePlayer mode;

    [SerializeField]
    private GameObject buttonTeleportText;

    public static Singleton2 instance;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        Singleton2.instance = this;
        this.score = 0;
        this.mode = ModePlayer.Teleport;
        this.buttonTeleportText.GetComponent<TextMeshProUGUI>().text = "Teleport";
    }


    public void InvertTeleport()
    {
        if (mode == ModePlayer.Teleport)
        {
            this.mode = ModePlayer.Collect;
            this.buttonTeleportText.GetComponent<TextMeshProUGUI>().text = "Collect";
        }
        else
        {
            this.mode = ModePlayer.Teleport;
            this.buttonTeleportText.GetComponent<TextMeshProUGUI>().text = "Teleport";

        }
        Debug.Log("Actual mode " +  this.mode);
    }

    public ModePlayer getMode()
    {
        return this.mode;
    }

    public void IncreaseScore()
    {
        this.score += 1;
    }

    public void Update()
    {
        Debug.Log("Score " + this.score);
    }


}
