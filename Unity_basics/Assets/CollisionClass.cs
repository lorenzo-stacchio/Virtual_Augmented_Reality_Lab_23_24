using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionClass : MonoBehaviour
{
    Vector3 customRotation;
    Vector3 initPosition;


    // Start is called before the first frame update
    void Start()
    {
        this.customRotation = new Vector3(90.0f, 0.0f, 0.0f);
        this.initPosition = this.transform.position;
    }


    private void OnCollisionEnter(Collision collision)
    {
        string name = collision.gameObject.name;
        Debug.Log("INCIDENTE NINONINO  " + name);

        if (collision.gameObject.tag == "Rotatable")
        {
            collision.gameObject.transform.Rotate(this.customRotation);
            // CHANGE COLOR
            this.gameObject.GetComponent<MeshRenderer>().material.color = this.ChangeColorRandomly();

            if (collision.gameObject.GetComponent<ChangeColorCont>() == null)
            {
                collision.gameObject.AddComponent<ChangeColorCont>();
                Destroy(this.gameObject.GetComponent<ChangeColorCont>());
            }
            else
            {
                this.gameObject.AddComponent<ChangeColorCont>();
                Destroy(collision.gameObject.GetComponent<ChangeColorCont>());
            }
        }

        if (collision.gameObject.tag == "Reposition")
        {
            this.gameObject.transform.position = this.initPosition;
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered");
        this.gameObject.GetComponent<MeshRenderer>().material.color = this.ChangeColorRandomly();

    }


    private Color ChangeColorRandomly()
    {
        Color temp = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        return temp;
    }


    private void OnBecameInvisible()
    {
        Manager.instance.CustomSpawn();
        
        DestroyImmediate(this.gameObject);
        //this.gameObject.transform.position = this.initPosition;
    }

}
