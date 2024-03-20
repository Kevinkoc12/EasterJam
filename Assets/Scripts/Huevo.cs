using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{
    float tiempo = 10;
    int fuerzaX, fuerzaY;
    public int maxFuerzaY;
    public int maxFuerzaX;
    public int puntos = 1;


    void Start()
    {

        fuerzaX = Random.Range(10, maxFuerzaX);
        if (Random.Range(0, 2) == 1)
        {
            fuerzaX *= -1;
        }
        fuerzaY = Random.Range(50, maxFuerzaY);

        /*
         //genera  un numero aleatorio para asignarselo a la gravedad
         GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.1f,1f);
        */

    }

    void Update()
    {
        while (tiempo > 0)
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(fuerzaX, fuerzaY));
            tiempo--;
        }
    }

    public void encestado()
    {
        GameManager.gameManager.anadirPuntos(puntos);

        Destroy(gameObject);
    }
}
