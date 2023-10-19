using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtesttest : MonoBehaviour
{
    [SerializeField]
    private float test; 

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotate(float value)
    {
        Quaternion rotation = Quaternion.Euler(new Vector3(value*360, this.transform.rotation.y, this.transform.rotation.z));
        this.transform.rotation = rotation;
    }

}
