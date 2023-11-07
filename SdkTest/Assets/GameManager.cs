using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject terrain;

    [SerializeField]
    GameObject toSpawn;

    [SerializeField]
    int nMushrooms;

    Dictionary<string,float> bbox = new Dictionary<string,float>();


    // Start is called before the first frame update
    void Start()
    {
        this.bbox = CalculateTerrainGeometry();
        Debug.Log("bbox " + this.bbox);

        SpawnMushrooms(this.bbox, this.nMushrooms);
    }


    // Update is called once per frame
    Dictionary<string, float> CalculateTerrainGeometry()
    {
        Dictionary<string, float> tempBbox = new Dictionary<string, float>();
        //BBOX: <x1:.., y1:..., x2:.., y2:...>

        MeshRenderer meshTerrain = this.terrain.GetComponent<MeshRenderer>();

        Bounds meshBounds = meshTerrain.bounds;

        // How to calculate the absolute bbox? 
        //float boundsX = terrain.transform.localScale.x * meshBounds.size.x;

        float x1 = (float)meshBounds.center.x - (float)meshBounds.size.x;
        float z1 = (float)meshBounds.center.z - (float)meshBounds.size.z;// * (this.terrain.transform.localScale.z) / 2.0f;
        float x2 = (float)meshBounds.center.x + (float)meshBounds.size.x;
        float z2 = (float)meshBounds.center.z + (float)meshBounds.size.z;

        tempBbox.Add("x1",x1);
        tempBbox.Add("x2", x2);
        tempBbox.Add("z1", z1);
        tempBbox.Add("z2", z2);

        float x_axis = Random.RandomRange(x1, x2);
        float z_axis = Random.RandomRange(z1, z2);

        GameObject spawned  = GameObject.Instantiate(this.toSpawn);
        spawned.transform.position = new Vector3(x_axis, 1, z_axis);

        //Debug.DrawLine(new Vector3(x1, 2, 0), new Vector3(x2, 2, 0), new Color(1.0f, 0.0f, 0.0f), 30);

        return tempBbox;

    } 


    void SpawnMushrooms(Dictionary<string,float> geometry, int n)
    {
        for (int i = 0; i < n; i++)
        {
            float x_axis = Random.RandomRange(geometry["x1"], geometry["x2"]);
            float z_axis = Random.RandomRange(geometry["z1"], geometry["z2"]);

            GameObject spawned = GameObject.Instantiate(this.toSpawn);
            spawned.transform.position = new Vector3(x_axis, 1, z_axis);
        }

    }





}
