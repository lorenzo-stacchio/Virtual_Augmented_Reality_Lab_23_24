using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // Start is called before the first frame update
    public void Collect()
    {
        if (Singleton2.instance.mode == ModePlayer.Collect)
        {
            Singleton2.instance.IncreaseScore();
            DestroyImmediate(this.gameObject);
        }
        
    }

}
