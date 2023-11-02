using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeMovement : MonoBehaviour
{
    float velocity;

    // Start is called before the first frame update
    void Start()
    {
        this.velocity = 1.0f;
    }


    // Update is called once per frame
    void Update()
    {
        float randomDirection = Random.Range(0.0f, 1.0f) >  0.3 ? 1.0f : -1.0f;

        this.transform.position = new Vector3(this.transform.position.x + (randomDirection * this.velocity * Time.deltaTime), this.transform.position.y, this.transform.position.z);
    }

}
