using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    [SerializeField]
    GameObject terrain;

    [SerializeField]
    GameObject toSpawn;

    [SerializeField]
    int nMushrooms;

    private Dictionary<string, float> bbox;
    private List<(float, float)> listSpawnPosition;


    // Start is called before the first frame update
    void Start()
    {
        this.bbox = CalculateBbox(this.terrain);
        //this.listSpawnPosition = CalculatePositionGrid(this.terrain, this.toSpawn.transform.Find("Sphere").gameObject);
        this.listSpawnPosition = CalculatePositionGrid2(this.terrain, this.toSpawn.transform.Find("Sphere").gameObject);

        //GenerateToSpawn(this.bbox, this.nMushrooms);

    }


    Dictionary<string, float> CalculateBbox(GameObject toBbox)
    {
        // declare dictionary
        Dictionary<string, float> tempBbox = new Dictionary<string, float>();

        MeshRenderer terrainMesh = toBbox.GetComponent<MeshRenderer>();
        Bounds bounds = terrainMesh.bounds;

        float width = bounds.size.x;
        float depth = bounds.size.z;

        Vector3 center = bounds.center;

        float x1 = center.x - width / 2;
        float z1 = center.z - depth / 2;
        float x2 = center.x + width / 2;
        float z2 = center.z + depth / 2;

        tempBbox.Add("x1", x1);
        tempBbox.Add("z1", z1);
        tempBbox.Add("x2", x2);
        tempBbox.Add("z2", z2);

        return tempBbox;
    }

    void GenerateToSpawn(Dictionary<string, float> bbox, int nMushrooms)
    {
        for (int i =0;  i < nMushrooms; i++)
        {
            float x = Random.Range(bbox["x1"], bbox["x2"]);
            float z = Random.Range(bbox["z1"], bbox["z2"]);

            GameObject spawned = Instantiate(this.toSpawn);
            
            spawned.name = "Mushroom_" + i.ToString();

            spawned.transform.position = new Vector3(x,0.5f,z);
        }


    }


    List<(float, float)> CalculatePositionGrid2(GameObject areaObject, GameObject bboxSpawn)
    {
        List<(float, float)> possibleCoordinates = new List<(float, float)>();

        int maxMushroomRow = (int) Mathf.Round(areaObject.GetComponent<MeshRenderer>().bounds.size.x / bboxSpawn.GetComponent<MeshRenderer>().bounds.size.x);
        int maxMushroomCol = (int) Mathf.Round(areaObject.GetComponent<MeshRenderer>().bounds.size.z / bboxSpawn.GetComponent<MeshRenderer>().bounds.size.z);

        float widthMushroom = bboxSpawn.GetComponent<MeshRenderer>().bounds.size.x;
        float depthMushroom = bboxSpawn.GetComponent<MeshRenderer>().bounds.size.z;


        for (int i = 0; i < maxMushroomRow; i++)
        {
            for (int j = 0; j < maxMushroomCol; j++)
            {
                float xspawn = this.bbox["x1"] + i * (widthMushroom) + widthMushroom /2;
                float zspawn = this.bbox["z1"] + j * (depthMushroom) + depthMushroom / 2;
                GameObject spawned = Instantiate(this.toSpawn);
                spawned.transform.position = new Vector3(xspawn, 1.0f, zspawn);
            }

        }

        Debug.Log(maxMushroomRow + " " + maxMushroomCol);


        return possibleCoordinates;
    }

    List<(float, float)> CalculatePositionGrid(GameObject areaObject,GameObject bboxSpawn)
    {

        //Calculate area
        MeshRenderer areaObjectMesh = areaObject.GetComponent<MeshRenderer>();

        //float area = areaObjectMesh.bounds.size.x * areaObjectMesh.bounds.size.z;

        //Calculate area mushroom
        MeshRenderer areabboxSpawn = bboxSpawn.GetComponent<MeshRenderer>();

        float maxInRow = (int)Mathf.Round(areaObjectMesh.bounds.size.x / areabboxSpawn.bounds.size.x);
        float maxInCol = (int)Mathf.Round(areaObjectMesh.bounds.size.z / areabboxSpawn.bounds.size.z);

        float total_mushrooms = maxInRow * maxInCol;

        Debug.Log(total_mushrooms);
        //int max_mushrooms = (int) Mathf.Round(area / areaToSpawn);

        List<(float, float)> tempListGrids = new List<(float, float)>();

        for (int i = 0; i < maxInRow; i++)
        {
            for (int j = 0; j < maxInCol; j++)
            {
                float centerx = this.bbox["x1"] + (i * areabboxSpawn.bounds.size.x) + areabboxSpawn.bounds.size.x;
                float centerz = this.bbox["z1"] + (j * areabboxSpawn.bounds.size.z) + areabboxSpawn.bounds.size.z;

                GameObject spawned = Instantiate(this.toSpawn);

                spawned.name = string.Format("Mushroom_{0}_{1}", i.ToString(), j.ToString());

                spawned.transform.position = new Vector3(centerx, 0.5f, centerz);

                //// Break if mushrooms are greater than 300
                //if (i * j >= 300)
                //{
                //    break;
                //}

            }
        }




        return tempListGrids;
    }



}
