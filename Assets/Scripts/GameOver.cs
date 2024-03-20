using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //campo del texto
    public TMP_Text puntosUI;

    void Start()
    {
        Cursor.visible = true;
        //modificar el texto para que se iguale a el valor del player pref
        puntosUI.text = "Score: " + PlayerPrefs.GetInt("Puntos").ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene("Juego");
    }
}
