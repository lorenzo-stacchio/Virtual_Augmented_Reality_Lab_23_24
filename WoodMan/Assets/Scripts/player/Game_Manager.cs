using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : GazeableObject
{
	public static bool end;
    int shifting_bound = 2; //use to avoid to spawn at the limits of the playground
    [SerializeField]
    private int mushrooms_numbers; //number of mushrooms you want to spawn
    public GameObject playground;
    public GameObject myPrefab;
    public GameObject house_to_avoid; 

	public void Start(){
		end = false;
        //get mushroom objects
        GameObject mushrooms = GameObject.Find("mushrooms_field");
        //Calcuate vertixes of the house area
        Vector3 center = playground.GetComponent<MeshRenderer>().bounds.center; //get the center of the plane
        Vector3 objectSize = playground.GetComponent<MeshRenderer>().bounds.size; //get size of the plane
        float top_left_x = center.x - (objectSize.x/2 - shifting_bound); //start x coordinate 
        float top_left_z = center.z - (objectSize.z/2 - shifting_bound); //start y coordinate
        float bot_right_x = center.x + (objectSize.x/2 - shifting_bound); //end x coordinate
        float bot_right_z = center.z + (objectSize.z/2 - shifting_bound); //end y coordinate
        float y = center.y + 1; 
        //Debug.Log("Playground" + center.ToString() + " " + objectSize.ToString());
        //Create n mushroom objects (n=mushrooms_numbers) randomly in the playfield
        for (int i = 0; i < mushrooms_numbers; i++)
        {
            bool out_of_house = false; //test out of house
            Vector3 spawn_position = Vector3.zero; // declare spawn position with default values
            
            while(!out_of_house){
                float spawn_x = Random.Range(top_left_x, bot_right_x), spawn_z = Random.Range(top_left_z, bot_right_z);
                spawn_position.x = spawn_x;
                spawn_position.z = spawn_z;
                out_of_house = this.check_out_house(spawn_x,spawn_z); // test
            }

            GameObject mushroom = Instantiate(myPrefab, spawn_position, Quaternion.identity);            
            mushroom.GetComponent<Transform>().parent = mushrooms.GetComponent<Transform>(); //set the object in the right place in hierarchy
            mushroom.name = "mushroom_" + i.ToString(); //give an id to the spawned object
            mushroom.AddComponent<mushroom>(); //add the script to the object
        }

	}


    bool check_out_house(float x,float z){
        Vector3 center = house_to_avoid.GetComponent<MeshRenderer>().bounds.center; //get the center of the plane
        Vector3 objectSize = house_to_avoid.GetComponent<MeshRenderer>().bounds.size; //get size of the plane
        Debug.Log("House" + center.ToString() + " " + objectSize.ToString());
        //Calcuate vertixes of the house area
        float top_left_x = center.x - (objectSize.x/2); //start x coordinate 
        float top_left_z = center.z - (objectSize.z/2); //start y coordinate
        float bot_right_x = center.x + (objectSize.x/2); //end x coordinate
        float bot_right_z = center.z + (objectSize.z/2); //end y coordinate
        Debug.Log(top_left_x.ToString() + "," + top_left_z.ToString() + "," + bot_right_x.ToString() + "," + bot_right_z.ToString() + ",");
        if ((x >= top_left_x && x <= bot_right_x) && (z >= top_left_z && z<=bot_right_z)){
            return false;
        } else {
            return true;
        }
    }



    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);
        //Check if we win the game
        if (WoodMan.instance.collected_mushrooms() == mushrooms_numbers){
            this.GetComponentInChildren<Text>().text = "Win!";
            Destroy(this);
        } 
        else{
            this.GetComponentInChildren<Text>().text = (mushrooms_numbers - WoodMan.instance.collected_mushrooms()).ToString() + " left!";
        }


    }

}
