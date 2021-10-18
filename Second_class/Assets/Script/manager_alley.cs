using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager_alley : MonoBehaviour
{
    private int points = 0;
    private int hits = 0;

    public GameObject ball;
    public GameObject pins;

    public Transform prefab_ball;
    public Transform prefab_pins;


    private void update_canvas(){
       var canvas = this.gameObject.transform.Find("game_points");
       Text text_in_child_of_canvas = canvas.gameObject.GetComponentInChildren<Text>(); // in this case we want to access properties of the text object
       text_in_child_of_canvas.text = "Points: " + this.points;
    }

    private void check_hits(){
       // check hits and if it is equal to 2 reset and spawn new pins
       // move the ball to its start position
       Vector3 spawn_ball_position = this.ball.GetComponent<save_position>().get_spawn_pos();
       //Vector3 spawn_ball_position = new Vector3(-21.93f, -0.47f, 33.35f);
       Destroy(this.ball.gameObject);
       //this.ball = Instantiate(prefab_ball, new Vector3(0f, 0f, 0f), Quaternion.identity).gameObject;
       this.ball = Instantiate(prefab_ball, spawn_ball_position, Quaternion.identity).gameObject;
       //this.ball.transform.position = spawn_ball_position;
       this.ball.transform.parent = GameObject.Find("ball_pins").transform;
       this.ball.gameObject.name = "ball";
       Debug.Log(this.ball.transform.position);
       if (this.hits == 2) {
           // spawn new pins in the previous position
           Vector3 spawn_pin_position = this.pins.GetComponent<save_position>().get_spawn_pos();
           Destroy(this.pins.gameObject);
           this.pins = Instantiate(prefab_pins, spawn_pin_position, Quaternion.identity).gameObject;
           this.pins.transform.parent = GameObject.Find("ball_pins").transform;
           this.pins.gameObject.name = "pins";
           this.hits = 0;
    }
    }

    public void increase_points(){
        this.points+=1;
        this.update_canvas();
    }

    public void increase_hits(){
        this.hits+=1;
        this.check_hits();
       }

}
