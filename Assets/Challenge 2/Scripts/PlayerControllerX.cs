using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogRate = 1; // Tiempo que el jugador tiene que esperar para disparar de nuevo
    private float nextDog = 0; // tiempo desde el inicio después del cual el jugador puede disparar nuevamente

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDog)
        {
            nextDog = Time.time + dogRate; // restablecer nextDog a la hora actual + dogRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
