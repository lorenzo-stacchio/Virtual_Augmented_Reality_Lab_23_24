using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject terrain;

    [SerializeField]
    private GameObject mushroom_prefab;

    [SerializeField]
    private GameObject mushroom_field;


    [SerializeField]
    private int mushroom_to_spawn;

    private Vector3 terrain_size;
    private Vector3 terrain_center;
    private Vector3 top_left;
    private Vector3 bot_right;




    // Start is called before the first frame update
    void Start()
    {
        this.get_field_geometry();
        this.generate_n_mushrooms(this.mushroom_to_spawn);

    }


    void get_field_geometry()
    {
        Mesh planeMesh = terrain.GetComponent<MeshFilter>().mesh;
        Bounds bounds = planeMesh.bounds;
        // size in pixels
        float boundsX = terrain.transform.localScale.x * bounds.size.x;
        float boundsY = terrain.transform.localScale.y * bounds.size.y;
        float boundsZ = terrain.transform.localScale.z * bounds.size.z;
        //Debug.Log(boundsX);
        //Debug.Log(boundsZ);
        this.terrain_size = new Vector3(boundsX, boundsY, boundsZ);
        this.terrain_center = bounds.center;//.bounds.center;
        Debug.Log(terrain_center);
        // We are moving along the x and z axis
        this.top_left = new Vector3((this.terrain_center.x - (this.terrain_size.x / 2)), 0, (this.terrain_center.z - (this.terrain_size.z / 2)));
        this.bot_right = new Vector3((this.terrain_center.x + (this.terrain_size.x / 2)), 0, (this.terrain_center.z + (this.terrain_size.z / 2)));
        Debug.Log(top_left);
        Debug.Log(bot_right);
    }



    void generate_n_mushrooms(int n)
    {
        IEnumerable<int> squares = Enumerable.Range(1, n).Select(x => x * x);
        foreach (int num in squares)
        {
            Debug.Log(num);
            float x = Random.Range(this.top_left.x, this.bot_right.x);
            float z = Random.Range(this.top_left.z, this.bot_right.z);

            Vector3 mushroom_position = new Vector3(x,this.terrain.transform.position.y,z);
            GameObject new_mushroom = Instantiate(this.mushroom_prefab);
            new_mushroom.name = "mushroom_" + num.ToString();
            new_mushroom.transform.position = mushroom_position;
            new_mushroom.transform.SetParent(this.mushroom_field.transform);
        }

    }


}
