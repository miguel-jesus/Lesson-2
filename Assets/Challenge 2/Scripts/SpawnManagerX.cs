using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
       
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int index = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
        Invoke("SpawnRandomBall", Random.Range(3, 5));
        /*
         Invocar solo llama a un método con retraso, invoca llamadas repetidas a un método con retraso y repite esa llamada de método durante el tiempo,
         por lo que si en lugar de usar la repetición de invocación simplemente llama a invocar al final del método, 
         comenzará a llamarlo recursivamente (una y otra vez) pero podrá establecer un nuevo retraso en cada llamada
         */
    }

}
