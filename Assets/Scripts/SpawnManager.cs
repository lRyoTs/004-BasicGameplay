using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval); //Call the method in a time and interval
    }

    //Spawn random animal
    private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length); //Get random animal
        //Instatiate de animal
        Instantiate(animalPrefabs[animalIndex], RandomSpawnPos(), Quaternion.Euler(0,180,0));
    }

    //Get random position of the animal spawn
    private Vector3 RandomSpawnPos() {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }

}
