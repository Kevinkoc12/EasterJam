using UnityEngine;

public class RestringirMovimientoRaton : MonoBehaviour
{
    void Start()
    {
        // Confina el cursor del ratón dentro de la ventana del juego
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        // Obtener la posición actual del ratón en coordenadas de pantalla
        Vector3 posicionMouse = Input.mousePosition;

        // Convertir la posición del ratón de coordenadas de pantalla a coordenadas del mundo
        Vector3 posicionEnElMundo = Camera.main.ScreenToWorldPoint(new Vector3(posicionMouse.x, posicionMouse.y, 10));

        // Actualizar solo la posición X del objeto para que siga la posición X del ratón
        transform.position = new Vector3(posicionEnElMundo.x, transform.position.y, transform.position.z);
    }
}
