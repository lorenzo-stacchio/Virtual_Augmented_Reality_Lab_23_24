using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject terrain;

    [SerializeField]
    private GameObject mushroom_prefab;

    [SerializeField]
    private GameObject mushroom_field;


    [SerializeField]
    private int mushrooms_to_spawn;
    private int mushrooms_collected;

    private static GameManager instance;

    private Vector3 terrain_size;
    private Vector3 terrain_center;
    private Vector3 top_left;
    private Vector3 bot_right;
    private TextMeshProUGUI punteggio;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        instance.mushrooms_collected = 0;
        instance.punteggio = GameObject.Find("Info_Game_Text").GetComponent<TextMeshProUGUI>();

        instance.get_field_geometry();
        instance.generate_n_mushrooms(instance.mushrooms_to_spawn);
    }


    void get_field_geometry()
    {
        Mesh planeMesh = terrain.GetComponent<MeshFilter>().mesh;
        Bounds bounds = planeMesh.bounds;
        // real size of the graphical object
        float boundsX = terrain.transform.localScale.x * bounds.size.x; //multiply the bounds of the mesh for the local scale factor
        float boundsY = terrain.transform.localScale.y * bounds.size.y;
        float boundsZ = terrain.transform.localScale.z * bounds.size.z;

        instance.terrain_size = new Vector3(boundsX, boundsY, boundsZ);
        instance.terrain_center = bounds.center;//.bounds.center;

        // We are moving along the x and z axis
        instance.top_left = new Vector3((instance.terrain_center.x - (instance.terrain_size.x / 2)), 0, (instance.terrain_center.z - (instance.terrain_size.z / 2)));
        instance.bot_right = new Vector3((instance.terrain_center.x + (instance.terrain_size.x / 2)), 0, (instance.terrain_center.z + (instance.terrain_size.z / 2)));
    }



    void generate_n_mushrooms(int n)
    {
        IEnumerable<int> squares = Enumerable.Range(1, n).Select(x => x * x);
        foreach (int num in squares)
        {
            float x = Random.Range(instance.top_left.x, instance.bot_right.x);
            float z = Random.Range(instance.top_left.z, instance.bot_right.z);

            Vector3 mushroom_position = new Vector3(x,instance.terrain.transform.position.y,z);
            GameObject new_mushroom = Instantiate(instance.mushroom_prefab);
            new_mushroom.name = "mushroom_" + num.ToString();
            new_mushroom.transform.position = mushroom_position;
            new_mushroom.transform.SetParent(instance.mushroom_field.transform);
        }
        string init_message = string.Format("Funghi raccolti: {0}/{1}", instance.mushrooms_collected.ToString(), instance.mushrooms_to_spawn.ToString());
        update_info(init_message);
    }


    void check_all_mushroom_collected(){
        if (instance.mushrooms_collected.Equals(instance.mushrooms_to_spawn)) //the game is end
        {
            // get points canvas and disable it
           string end_message = "Complimenti! Viva i funghi!";
           update_info(end_message);

        } else{
        string update_message = string.Format("Funghi raccolti: {0}/{1}", instance.mushrooms_collected.ToString(), instance.mushrooms_to_spawn.ToString());
        instance.update_info(update_message);
        }
    }


    void update_info(string message){
        punteggio.text = message;
    }


    public static void collect_mushroom(){
        instance.mushrooms_collected +=1;
        instance.check_all_mushroom_collected();
    }




}
