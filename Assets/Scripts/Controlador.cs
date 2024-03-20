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
        else if (random >= 46 && random <= 75)
        {
            Instantiate(huevos[1], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 76 && random <= 90)
        {
            Instantiate(huevos[2], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 91 && random <= 96)
        {
            Instantiate(huevos[3], spawnPoints[pos].position, spawnPoints[pos].rotation);
        }
        else if (random >= 97 && random <= 100)
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

        Debug.Log(GameManager.gameManager.puntos);

        if (GameManager.gameManager.puntos % 1000 == 0)
        {
            segundos -= 0.2f;
            
        }
    }

}
