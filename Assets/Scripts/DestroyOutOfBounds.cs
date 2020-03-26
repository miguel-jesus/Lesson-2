using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            //si perdemos se para la aplicacion despues de avisar ,esto es un añadido que no estaba en los tutoriales pero he querido buscar
            EditorApplication.isPlaying = false;
        }
    }
}
