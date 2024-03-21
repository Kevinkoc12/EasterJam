using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{

    public GameObject[] huevos;
    public Transform[] spawnPoints;

    public float segundos;


    IEnumerator generador()
    {
        int pos = Random.Range(0, spawnPoints.Length);
        int random = Random.Range(0, 100);

        if (random <= 45)
        {
            Instantiate(huevos[0], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 46 && random <= 74)
        {
            Instantiate(huevos[1], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 75 && random <= 89)
        {
            Instantiate(huevos[2], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 90 && random <= 94)
        {
            Instantiate(huevos[3], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 95 && random <= 100)
        {
            Instantiate(huevos[4], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }


        yield return new WaitForSeconds(segundos);

        StartCoroutine(generador());

    }

    void Start()
    {
        StartCoroutine(generador());
    }

    // Cada vez que sea multiplo de 1000 se reduce en x segundos
    void Update()
    {

        if (GameManager.gameManager.puntos == 500)
        {
            segundos= 1.5f;
        }
        else if (GameManager.gameManager.puntos == 1000)
        {
            segundos= 1.25f;
        }
        else if (GameManager.gameManager.puntos == 1500)
        {
            segundos= 1f;
        }
        else if (GameManager.gameManager.puntos == 2000)
        {
            segundos= 0.75f;
        }
        else if (GameManager.gameManager.puntos == 2500)
        {
            segundos= 0.5f;
        }

    }

}
