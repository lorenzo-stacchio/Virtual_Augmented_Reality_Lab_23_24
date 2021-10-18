using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class save_position : MonoBehaviour
{
  private Vector3 spawnPos;
     
     void Start(){
         this.spawnPos = transform.position;
     }
     
     public Vector3 get_spawn_pos(){
         //do other dependencies
         return this.spawnPos;
     } 
}