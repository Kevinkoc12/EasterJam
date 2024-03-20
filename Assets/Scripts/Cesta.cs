using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cesta : MonoBehaviour
{

    public Rigidbody2D rb;
    public float minX = 90f; // Límite mínimo en el eje X
    public float maxX = 1830f; // Límite máximo en el eje X
    //private float inputValue;
    //private Vector2 direction;

    void Update()
    {
        move();
    }

    void move()
    {

        // Obtener la posición actual del ratón en coordenadas de pantalla
        Vector3 posicionMouse = Input.mousePosition;

        // Restringir la posición del ratón dentro de los límites de la pantalla en el eje X
        float posX = Mathf.Clamp(posicionMouse.x, minX, maxX);

        // Convertir la posición restringida del ratón de coordenadas de pantalla a coordenadas del mundo
        Vector3 posicionEnElMundo = Camera.main.ScreenToWorldPoint(new Vector3(posX, posicionMouse.y, 10));

        // Actualizar solo la posición X del objeto para que siga la posición X del ratón
        transform.position = new Vector3(posicionEnElMundo.x, transform.position.y, transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Huevo")
        {
            collision.GetComponent<Huevo>().encestado();
        }
    }

}
