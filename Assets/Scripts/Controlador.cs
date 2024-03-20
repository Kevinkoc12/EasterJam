using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{

    public GameObject[] huevos;
    public Transform[] spawnPoints;

    public float segundos;

    IEnumerator generador ()
    {
        int valor = Random.Range(0,huevos.Length);
        int pos = Random.Range(0,spawnPoints.Length);

        Instantiate(huevos[valor], spawnPoints[pos].position, spawnPoints[pos].rotation);
        yield return new WaitForSeconds(segundos);

        StartCoroutine(generador());

    }

        void Start()
        {
            StartCoroutine(generador());
        }

}
