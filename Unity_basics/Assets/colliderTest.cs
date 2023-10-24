using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderTest : MonoBehaviour
{
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        this.startPosition = transform.position;
    }




















    //private void OnCollisionEnter(Collision collidedWith)
    //{
    //    string nameCollider = collidedWith.gameObject.name;

    //    if (collidedWith.gameObject.tag == "Reposition")
    //    {
    //        this.transform.position = this.startPosition;
    //    } else if (collidedWith.gameObject.tag == "Transposer")
    //    {
    //        collidedWith.gameObject.transform.Rotate(new Vector3(90.0f, 0, 0));
    //    }
    //    // else
    //    //{
    //    //    collidedWith.gameObject.transform.Rotate(new Vector3(90.0f, 0, 0));
    //    //}
    //}

    //private void OnBecameInvisible()
    //{
    //    this.transform.position = this.startPosition;
    //}



}
