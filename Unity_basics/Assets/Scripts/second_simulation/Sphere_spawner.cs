using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_spawner : MonoBehaviour
{
    //declare a GameObject which will be used to spawn a prefab
    [SerializeField]
    private GameObject sphereToSpawn;

    private void OnTriggerEnter(Collider other) {
      Debug.Log("A sphere touches the trigger");
      Vector3 spawnPosition = other.GetComponent<Magic_collision>().getStartPosition();
      Quaternion spawnRotation = Quaternion.Euler(Vector3.zero); 
      GameObject spawnedSphere = Instantiate(sphereToSpawn,spawnPosition, spawnRotation);
   }

}
