using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNubes : MonoBehaviour
{

    private float nextSpawnTime;
    float minInterval = 5f;
    float maxInterval = 10f;
    public GameObject nube;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnNube();
            // Calcular el tiempo para la próxima instancia.
            nextSpawnTime = Time.time + Random.Range(minInterval, maxInterval);
        }
    }

    void SpawnNube()
    {
        GameObject prefabToSpawn = null;

        prefabToSpawn = nube;

        if (prefabToSpawn != null)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }

    }

}
