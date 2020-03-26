using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {   
        //Invocar repeticion orden: 1- nombre de nuestro metodo sin (). 2- timepo que tarda en aparecer nuestro objeto desde el segundo 0. 
        //3- tiempo que tarda en repetir el proceso
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S)){
        //    SpawnRandomAnimal();
        //}
    }
    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        //randomizamos el lugar del spawn dentro de los valores que sabemos que tiene nuestro juego
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //orden de la instanciacion : 1-objeto a instanciar de la array. 2- Posicion del spawn 3- el quaternation rotation
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
