using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    private int counter;

    [SerializeField]
    private GameObject toSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Manager.instance = this;
        this.counter = 0;
    }


   public void CustomSpawn()
    {
        GameObject temp = Instantiate(this.toSpawn);
        temp.name = "new_sphere_" + this.counter.ToString();
        this.counter += 1;
    }



}
